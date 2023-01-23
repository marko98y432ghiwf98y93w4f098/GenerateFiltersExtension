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
using u.other;
using u.forms;

namespace VisualStudioCppExtensions
{
    internal sealed partial class main2
    {

       
        private void button2Click(object sender, EventArgs e)          //callback
        {
            ThreadHelper.ThrowIfNotOnUIThread();





            
            
            filterToDir.ProjectData p = new();          //prepare          //project
            {
                Project x = projectUtility.pActive();

                if (!x.xIsCpp()) { ErrorMessageBox("A C++ project must be selected"); return; }          //check   1   project

                p.p = new shared.Project((VCProject)x.Properties.Item("project").Object);
            }




           
            p.f.filesGet(p);          //files, filters


            {
                p.d.o.dir = new path(p.p.dir);          //data
                if (!p.d.o.dir.xFull()) { ErrorMessageBox("project root dir is not valid"); return; }
            }








            
            
            formQuestionFtd fq = new();          //gui          //check   2
            {
                fq.labelInfoProject2.Text = /*xText(*/p.p.name/*)*/;
                fq.labelInfoCalculate3.Text = /*xText(*/p.d.c.filter.x/*)*/;
                fq.labelInfoOut3.Text = /*xText(*/p.d.o.dir.x/*)*/;
            }
            {
                //fq.Width = Math.Max(fq.Width, 200 + TextRenderer.MeasureText(p.d.o.dir.x, fq.labelInfoOut3.Font).Width + 79);
            }
            fq.StartPosition = FormStartPosition.CenterScreen;
            fq.ShowDialog((IWin32Window)projectUtility.dte.MainWindow.LinkedWindowFrame);
            if (fq.r == formQuestionFtd.Result.none) return;

            

            
            p.f.check(p.e);          //check   3












            if (!p.e.full)          //work          //dir
            {
                projectUtility.documentsRefresh();
                string dn = projectUtility.dte.ActiveDocument?.Name;
                p.dirSet();
                projectUtility.documentActivate(dn);
            }





            
            if (p.e.full)          //error
            {
                formError fe = new();
                fe.textBox.Text = p.e.ToString();
                fe.StartPosition = FormStartPosition.CenterScreen;
                fe.ShowDialog((IWin32Window)projectUtility.dte.MainWindow.LinkedWindowFrame);
            }
        }
    }
}
