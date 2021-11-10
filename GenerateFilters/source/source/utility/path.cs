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
    public class pathUtility
    {

        public static string FindCommon(Dictionary<string, List<string>> filesPerItemType)
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






        public static HashSet<string> GenerateUniqueByFilter(ProjectData p)
        {
            var result = new HashSet<string>();


            //filter   root
            if (p.r.filterFull)
            {
                result.Add(p.r.filter);
                for (var i = p.r.filter.LastIndexOf(Path.DirectorySeparatorChar); i != -1; i = p.r.filter.LastIndexOf(Path.DirectorySeparatorChar, i - 1))
                    result.Add(p.r.filter.Substring(0, i));
            }


            //filter   others
            foreach (var fType in p.f.group)
                foreach (var f in fType.Value)
                {
                    var d = Path.GetDirectoryName(f);
                    if (d.Length <= p.r.dir.Length) continue;

                    d = GetExtensionFromCommon(p.r.dir, d);
                    result.Add(p.r.filterAppend(d));
                    for (var i = d.LastIndexOf(Path.DirectorySeparatorChar); i != -1; i = d.LastIndexOf(Path.DirectorySeparatorChar, i - 1))
                        result.Add(p.r.filterAppend(d.Substring(0, i)));
                }

            return result;
        }








        public static string GetRelativeIfNeeded(string parentPath, string file)
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
        public static string GetExtensionFromCommon(string commonPath, string path)
        {
            if (commonPath.Length == path.Length) return "";

            var shift = 0;
            if (path[commonPath.Length] == Path.DirectorySeparatorChar)
                shift = 1;

            return path.Substring(commonPath.Length + shift, path.Length - (commonPath.Length + shift));
        }





    }
}
