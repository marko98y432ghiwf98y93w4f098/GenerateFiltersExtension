using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VisualStudioCppExtensions
{
    public class pathUtility
    {

        public static string pathCommon(Dictionary<string, VCFile> files)
        {
            if (files == null || files.Count == 0) return string.Empty;

            var s = string.Empty;
            foreach (var f in files.Keys)
            {
                if (f == null) return string.Empty;

                if (s == string.Empty)
                {
                    s = Path.GetDirectoryName(f);
                    continue;
                }


                var fd = Path.GetDirectoryName(f);
                var i = 0;
                while (i < s.Length
                    && i < fd.Length
                    && s[i] == fd[i]) i++;


                if (i == 0) return string.Empty;
                if (i == s.Length) continue;
                if (i < s.Length) s = s.Substring(0, i);
            }
            return s;
        }






        /*public static HashSet<string> getFilterList(ProjectData p)
        {
            var result = new HashSet<string>();


            //filter   root
            if (p.r.filterFull)
            {
                result.Add(p.r.o.filter);
                for (var i = p.r.o.filter.LastIndexOf(Path.DirectorySeparatorChar); i != -1; i = p.r.o.filter.LastIndexOf(Path.DirectorySeparatorChar, i - 1))
                    result.Add(p.r.o.filter.Substring(0, i));
            }


            //filter   others
            foreach (var f in p.f.fileIn.Keys)
            {
                var d = Path.GetDirectoryName(f);
                if (p.r.c.dir.Length >= d.Length) continue;

                d = relativeDir(p.r.c.dir, d);
                result.Add(p.r.oFilterAdd(d));
                for (var i = d.LastIndexOf(Path.DirectorySeparatorChar); i != -1; i = d.LastIndexOf(Path.DirectorySeparatorChar, i - 1))
                    result.Add(p.r.oFilterAdd(d.Substring(0, i)));
            }

            return result;
        }*/








        /*public static string relativeFile(string path, string file)
        {
            if (Path.GetPathRoot(path) != Path.GetPathRoot(file)) return file;

            var fileUri = new Uri(file);

            // Folders must end in a slash
            if (!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
                path += Path.DirectorySeparatorChar;
            var pathUri = new Uri(path);

            return Uri.UnescapeDataString(pathUri.MakeRelativeUri(fileUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }*/








        
        /*public static string relativeDir(string path, string path2)
        {
            if (path.Length >= path2.Length) return "";

            int i = path.Length;
            if (path2[path.Length] == Path.DirectorySeparatorChar) i++;

            return path2.Substring(i);
        }*/





    }
}
