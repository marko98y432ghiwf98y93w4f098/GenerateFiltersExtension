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
            ThreadHelper.ThrowIfNotOnUIThread();
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
            //project
            ThreadHelper.ThrowIfNotOnUIThread();
            dirToFilter.ProjectData p = new dirToFilter.ProjectData();
            {
                Project x = projectUtility.GetActive();

                //check   1   project
                if (!projectUtility.IsCpp(x))
                {
                    ErrorMessageBox("A C++ project must be selected");
                    return;
                }

                p.p = new shared.Project((VCProject)x.Properties.Item("project").Object);
            }


            
            











            //files, filters
            p.f.filesGet(p);


            //data
            {
                p.d.i.dir = p.p.dir;
                {
                    path x2 = path.oCommon(p.f.f.f.a.file.Select(x => x.Key).ToArray());
                    p.d.c.dir = x2 == null ? null : x2.x;
                }
                if (string.IsNullOrEmpty(p.d.c.dir))
                {
                    ErrorMessageBox("No common sub-path between files, cannot generate filter!");
                    return;
                }
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
            fq.labelInfoProject2.Text = p.p.name;
            fq.labelInfoCalculate3.Text = p.d.c.dir;
            fq.labelInfoOut3.Text = p.d.o.filter;
            fq.StartPosition = FormStartPosition.CenterScreen;
            fq.ShowDialog((IWin32Window)p.p.p2.DTE.MainWindow.LinkedWindowFrame);
            if (fq.r == formQuestion.Result.none) return;




            //check   2   advanced
            if (fq.r == formQuestion.Result.advanced)
            {
                formAdvanced fa = new formAdvanced();
                fa.textBoxIn.Text = p.d.i.dir;
                fa.textBoxRootDir.Text = p.d.c.dir;
                fa.checkBoxCalculateDeleteFilters.Checked = p.d.c.fEmptyDelete;
                fa.StartPosition = FormStartPosition.CenterScreen;
                fa.p = p;
                fa.ShowDialog((IWin32Window)(p.p.p2.DTE.MainWindow.LinkedWindowFrame));

                if (fa.r != formAdvanced.Result.ok) return;

                if (fa.radioButtonInProject.Checked) p.d.i.mode = dirToFilter.ProjectData.Data.In.inMode.project;
                if (fa.radioButtonInDir.Checked) p.d.i.mode = dirToFilter.ProjectData.Data.In.inMode.dir;
                if (fa.radioButtonInDirSubDir.Checked) p.d.i.mode = dirToFilter.ProjectData.Data.In.inMode.dirSubDir;
                p.d.i.dir = fa.textBoxIn.Text;
                p.d.c.dir = fa.textBoxRootDir.Text;
                p.d.c.fEmptyDelete = fa.checkBoxCalculateDeleteFilters.Checked;
                if (fa.checkBoxRootFilter.Checked)
                    try { p.d.filterSet(fa.textBoxRootFilter.Text); } catch (Exception) { return; }
            }















            //filter
            p.f.filesIn(p);
            p.filtersGet();











            //error
            if (p.e.full)
            {
                formError fe = new formError();
                fe.textBox.Text = p.e.ToString();
                fe.StartPosition = FormStartPosition.CenterScreen;
                fe.ShowDialog((IWin32Window)((Project)(p.p.p.Object)).DTE.MainWindow.LinkedWindowFrame);
            }

        }
    }
}
