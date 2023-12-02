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
using System.Drawing;
using u.other;
using u.forms;
using u;

namespace extension
{
    internal sealed partial class main2
    {



        
        
        private void buttonClick(object sender, EventArgs e)          //callback
        {
            //ThreadHelper.ThrowIfNotOnUIThread();          2012





            dirToFilter.ProjectData p = new();          //prepare          //project
            {
                Project x = projectUtility.pActive();

                if (!x.xIsCpp()) { ErrorMessageBox("A C++ project must be selected"); return; }          //check   1   project

                p.p = new shared.Project(x.xProjectVc());
            }




            
            p.f.filesGet(p);          //files, filters




            {          //data

                p.d.i.dir = p.p.dir;          //in


                {
                    path x2 = path.oCommon(p.f.f.f.a.file.Select(x => x.Key).ToArray());          //calculate
                    p.d.c.dir = p.d.c.dirOptionHighest = x2 == null ? "" : x2.x;

                    /*if (p.d.c.dir.xEmpty())
                    {
                        ErrorMessageBox("No common sub-path between files, cannot generate filter!");
                        return;
                    }*/
                }
            }















            //gui          //check   2   confirm
            /*if (VsShellUtilities.ShowMessageBox(this.packageIServiceProvider,
                                                string.Format("Generate filter per folder for '{0}'?\nExisting filters will be erased", project.UniqueName),
                                                string.Empty,
                                                OLEMSGICON.OLEMSGICON_WARNING,
                                                OLEMSGBUTTON.OLEMSGBUTTON_OKCANCEL,
                                                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST) == Microsoft.Internal.VisualStudio.PlatformUI.DialogResult.Cancel)
                return;*/





            using formQuestion fq = new();          //check   2
            {
                fq.labelInfoProject2.Text = /*xText(*/p.p.name/*)*/;
                fq.labelInfoCalculate3.Text = /*xText(*/p.d.c.dir/*)*/;
                fq.labelInfoOut3.Text = /*xText(*/p.d.o.filter/*)*/;
            }
            {
                //fq.Width = Math.Max(fq.Width, 200 + TextRenderer.MeasureText(p.d.c.dir, fq.labelInfoCalculate3.Font).Width + 79);
            }
            fq.StartPosition = FormStartPosition.CenterScreen;
            fq.ShowDialog((IWin32Window)projectUtility.dte.MainWindow.LinkedWindowFrame);
            if (fq.r == formQuestion.Result.none) return;




            
            if (fq.r == formQuestion.Result.advanced)          //check   2   advanced
            {
                using formAdvanced fa = new();
                {
                    fa.textBoxIn.Text = p.d.i.dir;
                    fa.textBoxRootDir.Text = p.d.c.dir;
                    fa.checkBoxCalculateDeleteFilters.Checked = p.d.c.fEmptyDelete;
                    {
                        ContextMenuStrip x = fa.calculateMenu;
                        x.Items.Clear();
                        x.Items.Add(new ToolStripMenuItem("project dir:      " + p.p.dir) { Tag = p.p.dir });
                        {
                            string x2 = p.d.c.dirOptionHighest;
                            if (!x2.xE2()) x.Items.Add(new ToolStripMenuItem("highest common:   " + x2) { Tag = x2 });
                        }
                    }
                }
                fa.StartPosition = FormStartPosition.CenterScreen;
                fa.p = p;
                fa.ShowDialog((IWin32Window)projectUtility.dte.MainWindow.LinkedWindowFrame);

                if (fa.r != formAdvanced.Result.ok) return;

                {
                    if (fa.radioButtonInProject.Checked) p.d.i.mode = dirToFilter.ProjectData.Data.In.inMode.project;
                    if (fa.radioButtonInDir.Checked) p.d.i.mode = dirToFilter.ProjectData.Data.In.inMode.dir;
                    if (fa.radioButtonInDirSubDir.Checked) p.d.i.mode = dirToFilter.ProjectData.Data.In.inMode.dirSubDir;
                    p.d.i.dir = fa.textBoxIn.Text;
                    p.d.c.dir = fa.textBoxRootDir.Text;
                    p.d.c.fEmptyDelete = fa.checkBoxCalculateDeleteFilters.Checked;
                    if (fa.checkBoxRootFilter.Checked)
                        try { p.d.filterSet(fa.textBoxRootFilter.Text); } catch (Exception) { return; }
                }
            }
















            
            p.f.filesIn(p);          //work
            p.filtersSet();








            
            if (p.e.full)          //error
            {
                using formError fe = new();
                fe.textBox.Text = p.e.ToString();
                fe.StartPosition = FormStartPosition.CenterScreen;
                fe.ShowDialog((IWin32Window)projectUtility.dte.MainWindow.LinkedWindowFrame);
            }
        }
    }
}
