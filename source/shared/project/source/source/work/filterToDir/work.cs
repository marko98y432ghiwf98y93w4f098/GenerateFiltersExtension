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
    internal sealed partial class main2
    {

        //callback
        private void button2Click(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();





            //prepare
            //project
            filterToDir.ProjectData p = new filterToDir.ProjectData();
            {
                Project x = projectUtility.GetActive();

                //check   1   project
                if (!x.xIsCpp()) { ErrorMessageBox("A C++ project must be selected"); return; }

                p.p = new shared.Project((VCProject)x.Properties.Item("project").Object);
            }



            //files, filters
            p.f.filesGet(p);

            //data
            {
                p.d.o.dir = new path(p.p.dir);
                if (!p.d.o.dir.xFull()) { ErrorMessageBox("project root dir is not valid"); return; }
            }








            //gui
            //check   2
            formQuestionFtd fq = new formQuestionFtd();
            {
                fq.labelInfoProject2.Text = p.p.name;
                fq.labelInfoCalculate3.Text = p.d.c.filter.x;
                fq.labelInfoOut3.Text = p.d.o.dir.x;
            }
            {
                fq.Width = Math.Max(fq.Width, 200 + TextRenderer.MeasureText(p.d.o.dir.x, fq.labelInfoOut3.Font).Width + 79);
            }
            fq.StartPosition = FormStartPosition.CenterScreen;
            fq.ShowDialog((IWin32Window)((Project)(p.p.p.Object)).DTE.MainWindow.LinkedWindowFrame);
            if (fq.r == formQuestionFtd.Result.none) return;

            

            //check   3
            p.f.check(p.e);










            //work
            //dir
            if (!p.e.full)
            {
                projectUtility.documentsRefresh();
                string dn = projectUtility.dte.ActiveDocument?.Name;
                p.dirSet();
                projectUtility.documentActivate(dn);
            }





            //error
            if (p.e.full)
            {
                formError fe = new formError();
                fe.textBox.Text = p.e.ToString();
                fe.StartPosition = FormStartPosition.CenterScreen;
                fe.ShowDialog((IWin32Window)projectUtility.dte.MainWindow.LinkedWindowFrame);
            }

        }
    }
}
