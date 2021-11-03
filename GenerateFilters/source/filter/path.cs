using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Internal.VisualStudio.PlatformUI;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Text;

namespace VisualStudioCppExtensions
{
    internal sealed partial class filter
    {


        //path utils
        private static string FindCommonPath(Dictionary<string, List<string>> filesPerItemType)
        {
            if (filesPerItemType == null || filesPerItemType.Count == 0)
                return string.Empty;

            var result = string.Empty;
            foreach (var entry in filesPerItemType)
            {
                foreach (var path in entry.Value)
                {
                    if (path == null)
                        return string.Empty;

                    if (result == string.Empty)
                    {
                        result = Path.GetDirectoryName(path);
                        continue;
                    }

                    var currentPath = Path.GetDirectoryName(path);
                    var indexMaxEqual = 0;
                    while (indexMaxEqual < result.Length
                        && indexMaxEqual < currentPath.Length
                        && result[indexMaxEqual] == currentPath[indexMaxEqual])
                    {
                        ++indexMaxEqual;
                    }

                    if (indexMaxEqual == 0)
                        return string.Empty;

                    if (indexMaxEqual == result.Length)
                        continue;

                    if (indexMaxEqual < result.Length)
                        result = result.Substring(0, indexMaxEqual);
                }
            }
            return result;
        }

        private static HashSet<string> GenerateUniquePathByFilter(string commonPath, Dictionary<string, List<string>> filesPerItemType)
        {
            var result = new HashSet<string>();
            foreach (var entry in filesPerItemType)
                foreach (var file in entry.Value)
                {
                    var path = Path.GetDirectoryName(file);
                    if (path.Length == commonPath.Length)
                        continue;

                    path = GetPathExtensionFromCommonPath(commonPath, path);
                    result.Add(path);
                    for (var i = path.LastIndexOf(Path.DirectorySeparatorChar); i != -1; i = path.LastIndexOf(Path.DirectorySeparatorChar, i - 1))
                        result.Add(path.Substring(0, i));
                }
            return result;
        }

        static private string GetRelativePathIfNeeded(string parentPath, string file)
        {
            if (Path.GetPathRoot(parentPath) != Path.GetPathRoot(file))
                return file;

            var pathUri = new Uri(file);

            // Folders must end in a slash
            var formalizedUriParentPath = parentPath;
            if (!parentPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                formalizedUriParentPath += Path.DirectorySeparatorChar;
            }

            var folderUri = new Uri(formalizedUriParentPath);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        /// <summary>
        /// predicate: commonPath.Length < path.Length
        /// </summary>
        private static string GetPathExtensionFromCommonPath(string commonPath, string path)
        {
            var shift = 0;
            if (path[commonPath.Length] == Path.DirectorySeparatorChar)
                shift = 1;

            return path.Substring(commonPath.Length + shift, path.Length - commonPath.Length - shift);
        }





    }
}
