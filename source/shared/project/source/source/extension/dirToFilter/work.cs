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



        //callback
        void buttonBeforeQueryStatus(object sender, EventArgs e)
        {
            OleMenuCommand x = (OleMenuCommand)sender;
            if (x == null) return;

            bool b;
            try
            {
                b = projectUtility.IsCpp(projectUtility.GetActive());
            }
            catch(Exception)
            {
                b = false;
            }
            x.Visible = b;
            x.Enabled = b;
        }













        
        
        















        
        //callback
        private void buttonClick(object sender, EventArgs e)
        {
            //projectData
            dirToFilter.ProjectData p = new dirToFilter.ProjectData();
            ThreadHelper.ThrowIfNotOnUIThread();
            p.p = projectUtility.GetActive();











            //check   1   project
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
            {
                path x2 = path.oCommon(p.f.file.Select(x => x.Key).ToArray());
                p.r.c.dir = x2 == null ? null : x2.x;
            }
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
            fq.labelInfoCalculate3.Text = p.r.c.dir;
            fq.labelInfoOut3.Text = p.r.o.filter;
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

                if (fa.radioButtonInProject.Checked) p.r.i.mode = dirToFilter.ProjectData.Root.In.inMode.project;
                if (fa.radioButtonInDir.Checked) p.r.i.mode = dirToFilter.ProjectData.Root.In.inMode.dir;
                if (fa.radioButtonInDirSubDir.Checked) p.r.i.mode = dirToFilter.ProjectData.Root.In.inMode.dirSubDir;
                p.r.i.dir = fa.textBoxIn.Text;
                p.r.c.dir = fa.textBoxRootDir.Text;
                p.r.c.fEmptyDelete = fa.checkBoxCalculateDeleteFilters.Checked;
                if (fa.checkBoxRootFilter.Checked)
                    try { p.r.filterSet(fa.textBoxRootFilter.Text); } catch (Exception) { return; }
            }
















            //projectData   2
            p.filesIn();
            p.filtersGet();





            














            





























            
        }
    }
}
