




//items
/*private static IEnumerable<ProjectItem> items(ProjectItem i)
{
    ThreadHelper.ThrowIfNotOnUIThread();
    yield return i;
    foreach (var i2 in items(i.ProjectItems))
        yield return i2;
}

public static IEnumerable<ProjectItem> items(ProjectItems i)
{
    if (i != null)
        foreach (ProjectItem i2 in i)
            if (i2 != null)
                foreach (ProjectItem i3 in items(i2))
                    yield return i3;
}*/

















//public static string GetAssemblyLocalPathFrom(Type type) => new Uri(type.Assembly.CodeBase, UriKind.Absolute).LocalPath;


















/*public static void SetAdditionalIncludeDirectories(Project project, Dictionary<string, List<string>> filesPerItemType, string projectPath)
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
}*/