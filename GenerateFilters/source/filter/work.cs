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




namespace VisualStudioCppExtensions
{
    internal sealed partial class filter
    {



        //callbacks
        /// <summary>
        /// Only Display Generate Filter Button if we right click on a C++ Project
        /// </summary>
        void OnBeforeQueryStatusCallBack(object sender, EventArgs e)
        {
            var menuCommand = sender as OleMenuCommand;
            if (menuCommand == null)
                return;

            var shouldActivateButton = IsCppProject(GetActiveProject());
            menuCommand.Visible = shouldActivateButton;
            menuCommand.Enabled = shouldActivateButton;
        }















        


        public void propertyList(Properties p, HashSet<string> x)
        {
            foreach (Property x2 in p)
                x.Add(x2.Name);
        }





        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            //project
            ThreadHelper.ThrowIfNotOnUIThread();
            Project project = GetActiveProject();
            if (!IsCppProject(project))
            {
                ErrorMessageBox("A C++ project must be selected to generate filter!");
                return;
            }
            VCProject project2 = (VCProject)project.Properties.Item("project").Object;







            {
                object o3 = project2.References;
                VCReferences o4 = project2.VCReferences;
                VCReferences o5 = (VCReferences)o3;
                bool x = (object.ReferenceEquals(o4, o5));
            }





            //properties   project
            /*{
                HashSet<string> s = new HashSet<string>();
                foreach (Project x in project.DTE.Solution.Projects)
                    propertyList(project.Properties, s);
                string s2 = "";
                foreach (string s3 in s.ToList().OrderBy(x => x)) s2 += s3 + "\r\n";
            }*/



            //properties   projectItems
            /*{
                HashSet<string> s = new HashSet<string>();
                foreach (Project p in project.DTE.Solution.Projects)
                    foreach (ProjectItem p2 in p.ProjectItems)
                    {
                        if (p2.Kind != EnvDTE.Constants.vsProjectItemKindPhysicalFile) continue;
                        propertyList(p2.Properties, s);
                    }
                string s2 = "";
                foreach (string s3 in s.ToList().OrderBy(x => x)) s2 += s3 + "\r\n";
            }*/











            //confirm
            if (VsShellUtilities.ShowMessageBox(this.packageIServiceProvider,
                                                string.Format("Generate filter per folder for '{0}'?\nExisting filters will be erased", project.UniqueName),
                                                string.Empty,
                                                OLEMSGICON.OLEMSGICON_WARNING,
                                                OLEMSGBUTTON.OLEMSGBUTTON_OKCANCEL,
                                                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST) == DialogResult.Cancel)
                return;










            //project items
            HashSet<ProjectItem> projectItems = new HashSet<ProjectItem>();
            {
                //project   other in solution
                LinkedList<Project> p2 = new LinkedList<Project>();
                foreach (Project p in project.DTE.Solution.Projects)
                {
                    if (p.FullName == project.FullName) continue;
                    p2.AddLast(p);
                }

                //projectItems   other in solution
                projectItems = new HashSet<ProjectItem>(Recurse(project.ProjectItems)).Where(x => x.Kind == EnvDTE.Constants.vsProjectItemKindPhysicalFile).ToHashSet();
                HashSet<ProjectItem> p2Items = new HashSet<ProjectItem>();
                foreach (Project x in p2) p2Items.UnionWith(Recurse(x.ProjectItems));
                p2Items = p2Items.Where(x => x.Kind == EnvDTE.Constants.vsProjectItemKindPhysicalFile).ToHashSet();

                //exclude
                //projectItems.RemoveWhere(x => p2Items.Any(x2 => ((string)x2.Properties.Item("FullPath").Value).Equals((string)x.Properties.Item("FullPath").Value, StringComparison.OrdinalIgnoreCase)));
            }









            // ClCompile -> .cpp, .cc, .c, ...
            // ClInclude -> .h, .hxx, .hpp, ...
            // None -> Makefile, .gitignore, ...
            var filesPerItemType = new Dictionary<string /* ItemType */, List<string> /* Files FullPath */>();
            foreach (ProjectItem projectItem in projectItems)
            {

                try
                {

                    {
                        string o = (string)projectItem.Name;
                        if (!string.IsNullOrEmpty(o))
                        {
                            int x = 5;
                        }
                    }


                    {
                        try
                        {
                            Type t = projectItem.Properties.Item("project").Value.GetType();
                            object o = projectItem.Properties.Item("project").Object;
                            VCProject p = (VCProject)o;
                            string p2 = p.Name;
                        }
                        catch(Exception e2)
                        {

                        }
                    }









                    var itemType = projectItem.Properties.Item("ItemType").Value as string;
                    if (string.IsNullOrEmpty(itemType))
                        continue;

                    if (!filesPerItemType.ContainsKey(itemType))
                        filesPerItemType.Add(itemType, new List<string>());

                    filesPerItemType[itemType].Add(projectItem.Properties.Item("FullPath").Value as string);
                }
                catch (Exception exc)
                {
                    // nothing
                }

            }

            var commonPath = FindCommonPath(filesPerItemType);
            if (string.IsNullOrEmpty(commonPath))
            {
                ErrorMessageBox("No common sub-path between files, cannot generate filter!");
                return;
            }

            // Keep for Post-Unloading
            var projectFilename = project.FileName;
            var projectPath = Path.GetDirectoryName(projectFilename);
            var pIsVcxitems = projectFilename.EndsWith(".vcxitems", StringComparison.OrdinalIgnoreCase);
            project.DTE.ExecuteCommand("Project.UnloadProject");

            var xmlSettings = new XmlWriterSettings() { Indent = true };
            using (var xmlWriter = XmlWriter.Create(projectFilename + ".filters", xmlSettings))
            {
                xmlWriter.WriteStartElement("Project");
                xmlWriter.WriteAttributeString("ToolsVersion", "4.0");
                xmlWriter.WriteAttributeString("Project", "xmlns", null, @"http://schemas.microsoft.com/developer/msbuild/2003");

                WriteFilter(xmlWriter, GenerateUniquePathByFilter(commonPath, filesPerItemType));
                foreach (var entry in filesPerItemType)
                    WriteSources(xmlWriter, entry.Key, entry.Value, projectPath, commonPath, pIsVcxitems);

                xmlWriter.WriteEndElement();
            }
            project.DTE.ExecuteCommand("Project.ReloadProject");
        }








    }
}
