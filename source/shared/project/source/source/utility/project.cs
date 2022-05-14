using System;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.VCProjectEngine;

namespace VisualStudioCppExtensions
{
    public static class projectUtility
    {
        //dte
        public static DTE dte => (DTE)Package.GetGlobalService(typeof(SDTE));




        //project   active
        public static Project GetActive() => GetActive(dte);


        public static Project GetActive(DTE dte)
        {
            object[] x = (object[])dte.ActiveSolutionProjects;
            if (x.xEmpty()) return null;
            return (Project)x[0];
        }







        //project   cpp
        public static bool xIsCpp(this Project x)
        {
            return x != null
                   && (x.CodeModel.Language == CodeModelLanguageConstants.vsCMLanguageMC
                       || x.CodeModel.Language == CodeModelLanguageConstants.vsCMLanguageVC);
        }

        public static VCProject xProjectVc(this Project x) => (VCProject)x.Properties.Item("project").Object;











        //documents
        public static void documentsRefresh()          //push   document tab lazy open
        {
            foreach (Document x4 in dte.Documents) { }
        }


        public static void documentActivate(string x)          //push   document tab lazy open
        {
            if (x == null) return;
            {
                Document x2 = dte.ActiveDocument;
                if (x2?.Name == x) return;
            }
            foreach (Document x2 in dte.Documents)
                if (x2.Name == x)
                {
                    x2.Activate();
                    break;
                }
        }


    }
}
