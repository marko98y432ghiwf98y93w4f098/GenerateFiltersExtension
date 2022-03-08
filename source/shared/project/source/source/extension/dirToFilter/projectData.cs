using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.VCProjectEngine;
using VisualStudioCppExtensions.shared;


namespace VisualStudioCppExtensions
{
    namespace dirToFilter
    {
        public class ProjectData
        {
            public shared.Project p;
            


            public struct Files
            {
                public filters2 f;
                public Dictionary<string, file> fileIn;


                public void filesGet(ProjectData p)
                {
                    f = new filters2();
                    f.init(p.p, p.e);
                }

                public void filesIn(ProjectData p)
                {
                    Dictionary<string, file> x2 = f.f.a.file;
                    path d2 = new path(p.d.i.dir);
                    fileIn = (p.d.i.mode == Data.In.inMode.project) ? x2 :
                               (p.d.i.mode == Data.In.inMode.dirSubDir) ?
                                   x2.Where(x => (x.Value.xn - d2) != null).ToDictionary(x => x.Key, x => x.Value) :
                                   x2.Where(x => (x.Value.xn - d2)?.count == 1).ToDictionary(x => x.Key, x => x.Value);
                }
            }
            public Files f = new Files();








            

















            public class Data
            {
                public class In
                {
                    public enum inMode
                    {
                        project,
                        dir,
                        dirSubDir
                    }
                    public inMode mode;
                    public string dir;
                }
                public In i = new In();

                public class Calculate
                {
                    public string dir;
                    public bool fEmptyDelete = true;
                }
                public Calculate c = new Calculate();

                public class Out
                {
                    public string filter;
                }
                public Out o = new Out();



                public string oFilterAdd(string s)
                {
                    bool sFull = !string.IsNullOrWhiteSpace(s);
                    bool rFull = filterFull;
                    return (rFull ? o.filter : "") +
                        ((rFull && sFull) ? "\\" : "") +
                        (sFull ? s : "");
                }

                public bool filterFull => !string.IsNullOrWhiteSpace(o.filter);


                public static bool filterCheck(string s)
                {
                    if (string.IsNullOrWhiteSpace(s)) return true;
                    return !s.Any(x => !(char.IsLetterOrDigit(x) || x == ' ' || x == '\\' || x == '/'));
                }


                public void filterSet(string s)
                {
                    o.filter = "";
                    if (string.IsNullOrWhiteSpace(s)) { o.filter = ""; return; }

                    //check
                    if (!filterCheck(s)) throw new Exception();

                    string[] s2 = s.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    StringBuilder s3 = new StringBuilder();
                    for (int i = 0; i < s2.Length; i++)
                    {
                        s3.Append(s2[i]);
                        if (i < s2.Length - 1) s3.Append('\\');
                    }
                    o.filter = s3.ToString();
                }
            }
            public Data d = new Data();




            public error e = new error();

























            








































           





            public void filtersGet()
            {
                f.f.fDeleteEmpty(f.fileIn, d.c.fEmptyDelete);
                f.f.fRoot = f.f.fAdd(f.f.f.f, d.o.filter);
                f.f.fAdd(f.fileIn, new path(d.c.dir));
            }
        }


    }
}
