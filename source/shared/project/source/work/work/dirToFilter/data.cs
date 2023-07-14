using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.VCProjectEngine;
using extension.shared;
using u.other;
using u;


namespace extension
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
                    path d2 = new(p.d.i.dir);
                    fileIn = (p.d.i.mode == Data.In.inMode.project) ? x2 :
                               (p.d.i.mode == Data.In.inMode.dirSubDir) ?
                                   x2.Where(x => (x.Value.xn - d2) != null).ToDictionary(x => x.Key, x => x.Value) :
                                   x2.Where(x => (x.Value.xn - d2)?.count == 1).ToDictionary(x => x.Key, x => x.Value);
                }
            }
            public Files f = new();








            

















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
                public In i = new();

                public class Calculate
                {
                    public string dir;
                    public bool fEmptyDelete = true;
                    public string dirOptionHighest;
                }
                public Calculate c = new();

                public class Out
                {
                    public string filter;
                }
                public Out o = new();



                /*public string oFilterAdd(string s)
                {
                    bool rFull = !o.filter.xEmpty();
                    bool sFull = !s.xEmpty();
                    return (rFull ? o.filter : "") +
                        ((rFull && sFull) ? "\\" : "") +
                        (sFull ? s : "");
                }*/
              
                public static bool filterCheck(string s)
                {
                    if (s.xE2()) return true;
                    return !s.Any(x => !(char.IsLetterOrDigit(x) || x == ' ' || x == '\\' || x == '/'));
                }

                public void filterSet(string s)
                {
                    o.filter = "";

                    if (s.xE2()) { o.filter = ""; return; }

                    //check
                    if (!filterCheck(s)) throw new();
                    {
                        string[] s2 = s.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries).Where(x => !x.xE2()).ToArray();
                        StringBuilder s3 = new();
                        for (int i = 0; i < s2.Length; i++)
                        {
                            s3.Append(s2[i]);
                            if (i < s2.Length - 1) s3.Append('\\');
                        }
                        o.filter = s3.ToString();
                    }
                }
            }
            public Data d = new();




            public error e = new();

























            








































           





            public void filtersSet()
            {
                f.f.fDeleteEmpty(f.fileIn, d.c.fEmptyDelete);          //delete already empty filters
                f.f.fRoot = f.f.fAdd(f.f.f.f, d.o.filter);          //rootFilter   add
                f.f.fAdd(f.fileIn, new path(d.c.dir));          //filters   add
            }
        }


    }
}
