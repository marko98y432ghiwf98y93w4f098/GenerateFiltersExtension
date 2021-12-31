using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.VCProjectEngine;
using Microsoft.Internal.VisualStudio.PlatformUI;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace VisualStudioCppExtensions
{
    internal sealed partial class extension
    {



        //callbacks
        /// <summary>
        /// Only Display Generate Filter Button if we right click on a C++ Project
        /// </summary>
        void OnBeforeQueryStatusCallBack(object sender, EventArgs e)
        {
            OleMenuCommand menuCommand = (OleMenuCommand)sender;
            if (menuCommand == null) return;

            bool b;
            try
            {
                b = projectUtility.IsCpp(projectUtility.GetActive());
            }
            catch(Exception)
            {
                b = false;
            }
            menuCommand.Visible = b;
            menuCommand.Enabled = b;
        }













        
        
        















        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            //input
            ProjectData p = new ProjectData();











            //check   1   project
            ThreadHelper.ThrowIfNotOnUIThread();
            p.p = projectUtility.GetActive();
            if (!projectUtility.IsCpp(p.p))
            {
                ErrorMessageBox("A C++ project must be selected to generate filter!");
                return;
            }












            //projectData
            p.p2 = (VCProject)p.p.Properties.Item("project").Object;
            p.fileName = p.p.FileName;
            p.path = Path.GetDirectoryName(p.fileName);
            p.isVcxitems = p.fileName.EndsWith(".vcxitems", StringComparison.OrdinalIgnoreCase);
            p.filesGet();
            //p.filesGroup();
            p.r.i.dir = p.path;
            p.r.c.dir = pathUtility.pathCommon(p.f.file);
            if (string.IsNullOrEmpty(p.r.c.dir))
            {
                ErrorMessageBox("No common sub-path between files, cannot generate filter!");
                return;
            }













            //check   2   confirm
            /*if (VsShellUtilities.ShowMessageBox(this.packageIServiceProvider,
                                                string.Format("Generate filter per folder for '{0}'?\nExisting filters will be erased", project.UniqueName),
                                                string.Empty,
                                                OLEMSGICON.OLEMSGICON_WARNING,
                                                OLEMSGBUTTON.OLEMSGBUTTON_OKCANCEL,
                                                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST) == Microsoft.Internal.VisualStudio.PlatformUI.DialogResult.Cancel)
                return;*/




            //check   2
            formQuestion fq = new formQuestion();
            fq.labelInfoProject2.Text = p.p.Name;
            fq.labelInfoRootDir2.Text = p.r.c.dir;
            fq.labelInfoRootFilter2.Text = p.r.o.filter;
            fq.StartPosition = FormStartPosition.CenterScreen;
            fq.ShowDialog((IWin32Window)p.p.DTE.MainWindow.LinkedWindowFrame);
            if (fq.r == formQuestion.Result.none) return;




            //check   2   advanced
            if (fq.r == formQuestion.Result.advanced)
            {
                formAdvanced fa = new formAdvanced();
                fa.textBoxIn.Text = p.r.i.dir;
                fa.textBoxRootDir.Text = p.r.c.dir;
                fa.checkBoxCalculateDeleteFilters.Checked = p.r.c.fEmptyDelete;
                fa.StartPosition = FormStartPosition.CenterScreen;
                fa.p = p;
                fa.ShowDialog((IWin32Window)p.p.DTE.MainWindow.LinkedWindowFrame);

                if (fa.r != formAdvanced.Result.ok) return;

                if (fa.radioButtonInProject.Checked) p.r.i.mode = ProjectData.Root.In.inMode.project;
                if (fa.radioButtonInDir.Checked) p.r.i.mode = ProjectData.Root.In.inMode.dir;
                if (fa.radioButtonInDirSubDir.Checked) p.r.i.mode = ProjectData.Root.In.inMode.dirSubDir;
                p.r.i.dir = fa.textBoxIn.Text;
                p.r.c.dir = fa.textBoxRootDir.Text;
                p.r.c.fEmptyDelete = fa.checkBoxCalculateDeleteFilters.Checked;
                if (fa.checkBoxRootFilter.Checked)
                    try { p.r.filterSet(fa.textBoxRootFilter.Text); } catch (Exception) { return; }
            }
















            //projectData   2
            p.filesIn();
            p.filtersGet();





            














            //test
            /*{
                foreach (VCFile x in (IVCCollection)p.p2.Files)
                {
                    string kind = x.Kind;


                    string fullPath = x.FullPath;
                    string relativePath = x.RelativePath;
                    string unexpandedRelativePath = x.UnexpandedRelativePath;
                    //string itemFileName = x;
                    //string itemFullPath = x;
                    //string persistPath = x;


                    string itemName = x.ItemName;
                    string name = x.Name;


                    string extension = x.Extension;
                    string itemType = x.ItemType;
                    string contentType = x.ContentType;
                    string fileType = x.FileType.ToString();
                    string subType = x.SubType;
                    
                    

                    //bool isBuildable = x;
                    //bool isGenerator = x;
                    //bool isSharedItem = x;
                    bool deploymentContent = x.DeploymentContent;



                    //externalCookie = x;
                    //externalCookieId = x;


                    //object projectItem = x;
                    //object vsObject = x;
                    object object2 = x.Object;

                    object parent = x.Parent;
                    //object parentName = x;

                    object items = x.Items;

                    object project = x.project;
                    //object projectInternal = x;
                    //object containingSharedProject = x;
                    string customTool = x.CustomTool;
                    //object toolInternal = x;
                    object vcProjectEngine = x.VCProjectEngine;

                    object fileConfigurations = x.FileConfigurations;
                    //object projectConfiguration = x;
           

                    }
            }
            */





























            /*
            //calculate
            //project   unload
            p.p.DTE.ExecuteCommand("Project.UnloadProject");



            //write
            {
                XmlWriter xmlWriter = XmlWriter.Create(p.fileName + ".filters", new XmlWriterSettings() { Indent = true });
                xmlWriter.WriteStartElement("Project");
                xmlWriter.WriteAttributeString("ToolsVersion", "4.0");
                xmlWriter.WriteAttributeString("Project", "xmlns", null, @"http://schemas.microsoft.com/developer/msbuild/2003");

                WriteFilter(xmlWriter, pathUtility.getFilterList(p));
                foreach (var x in p.f.group)
                    WriteSources(xmlWriter, x.Key, x.Value, p);

                xmlWriter.WriteEndElement();
                xmlWriter.Close();
            }



            //project   reload
            p.p.DTE.ExecuteCommand("Project.ReloadProject");
            */
        }
    }
}
