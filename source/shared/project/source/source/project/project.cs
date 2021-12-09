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
        //aactive
        public static Project GetActive()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            DTE dte = (DTE)Package.GetGlobalService(typeof(SDTE));
            return GetActiveProject(dte);
        }

        public static Project GetActiveProject(DTE dte)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            var activeSolutionProjects = dte.ActiveSolutionProjects as Array;
            if (activeSolutionProjects == null || activeSolutionProjects.Length == 0)
                return null;

            return activeSolutionProjects.GetValue(0) as Project;
        }





        //cpp
        public static bool IsCpp(Project project)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            return project != null
                   && (project.CodeModel.Language == CodeModelLanguageConstants.vsCMLanguageMC
                       || project.CodeModel.Language == CodeModelLanguageConstants.vsCMLanguageVC);
        }






        //items
        public static IEnumerable<ProjectItem> Recurse(ProjectItems i)
        {
            if (i != null)
            {
                foreach (ProjectItem j in i)
                {
                    if (j == null) continue;
                    foreach (ProjectItem k in Recurse(j))
                    {
                        yield return k;
                    }
                }
            }
        }

        public static IEnumerable<ProjectItem> Recurse(ProjectItem i)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            yield return i;
            foreach (var j in Recurse(i.ProjectItems))
            {
                yield return j;
            }
        }




        public static string GetAssemblyLocalPathFrom(Type type) => new Uri(type.Assembly.CodeBase, UriKind.Absolute).LocalPath;


















        public static void SetAdditionalIncludeDirectories(Project project, Dictionary<string, List<string>> filesPerItemType, string projectPath)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            if (!filesPerItemType.ContainsKey("ClInclude"))
                return;

            var includePaths = new HashSet<string> { @"$(StlIncludeDirectories)" };
            foreach (var file in filesPerItemType["ClInclude"])
            {
                includePaths.Add(pathUtility.GetRelativeIfNeeded(projectPath, Path.GetDirectoryName(file)));
            }

            string filterAssemblyInstallionPath = Path.GetDirectoryName(GetAssemblyLocalPathFrom(typeof(package2)));

            DTE dte = (DTE)Package.GetGlobalService(typeof(DTE));
            if (dte.Version.StartsWith("17")) Assembly.LoadFrom(Path.Combine(filterAssemblyInstallionPath, @"Resources\\VCProjectEngine_17.0.dll"));
            else
                throw new Exception();

            dynamic vcProject = project.Object;
            foreach (dynamic vcConfiguration in vcProject.Configurations)
            {
                foreach (dynamic genericTool in vcConfiguration.Tools)
                {
                    dynamic compilerTool = genericTool;
                    if (compilerTool != null && compilerTool.GetType().FullName == "Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.VCCLCompilerToolShim")
                    {
                        // runtime
                        if (compilerTool.AdditionalIncludeDirectories == null)
                            compilerTool.AdditionalIncludeDirectories = string.Empty;

                        var currentAdditionalIncludeDirectories = new HashSet<string>(compilerTool.AdditionalIncludeDirectories.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
                        var pathsToAdd = new StringBuilder();
                        foreach (var includePath in includePaths)
                            // Avoid updating AdditionalIncludeDirectories when applicable to avoid reloading the project
                            if (!currentAdditionalIncludeDirectories.Contains(includePath))
                                pathsToAdd.Append(includePath + ';');

                        if (pathsToAdd.Length > 0)
                            compilerTool.AdditionalIncludeDirectories = pathsToAdd.ToString() + compilerTool.AdditionalIncludeDirectories;
                    }
                }
            }
        }







    }
}
