using System;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace VisualStudioCppExtensions
{
    public class projectUtility
    {
        //active
        public static Project GetActive()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            return GetActive((DTE)Package.GetGlobalService(typeof(SDTE)));
        }

        public static Project GetActive(DTE dte)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            object[] x = (object[])dte.ActiveSolutionProjects;
            if (x.xEmpty()) return null;
            return (Project)x[0];
        }













        //cpp
        public static bool IsCpp(Project project)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            return project != null
                   && (project.CodeModel.Language == CodeModelLanguageConstants.vsCMLanguageMC
                       || project.CodeModel.Language == CodeModelLanguageConstants.vsCMLanguageVC);
        }

    }
}
