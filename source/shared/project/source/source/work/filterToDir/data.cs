using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.VCProjectEngine;
using System.Threading;
using VisualStudioCppExtensions.shared;
using Project = VisualStudioCppExtensions.shared.Project;

namespace VisualStudioCppExtensions
{
    namespace filterToDir
    {
        public partial class ProjectData
        {
            //project
            public Project p;








            public class Files
            {
                public filters f;

                public void filesGet(ProjectData p)
                {
                    f = new filters();
                    f.init(p.p, p.e);
                }




                //check
                private char[] checkC = Path.GetInvalidPathChars().Union(Path.GetInvalidFileNameChars()).ToArray();
                private void check2(filter x, error e)
                {
                    //chars
                    if (x.xn2 != null)
                    {
                        bool b = true;
                        foreach (char c in checkC)
                            if (x.xn2.Contains(c)) { b = false; break; }
                        if (!b) e.add(new error.data() { t = error.Type.dirName, s = new string[] { x.xn.x } });
                    }


                    //exist   file
                    foreach (var x3 in x.o.file.Where(x2 => !File.Exists(x2.Key)))
                        e.add(new error.data() { t = error.Type.existFile, s = new string[] { "path:     " + x3.Key, "filter:   " + dir.file2.fileRelative(x3.Value).x } });

                    //same   file
                    foreach (var x3 in x.o.file.GroupBy(x2 => dir.file2.fileRelative(x2.Value).x.ToLower()).Where(x2 => x2.Count() > 1))
                        e.add(new error.data() { t = error.Type.sameFile, s = new string[] { x3.Key } });

                    //same   filter
                    foreach (var x3 in x.o.filter.GroupBy(x2 => x2.Value.xn.x.ToLower()).Where(x2 => x2.Count() > 1))
                        e.add(new error.data() { t = error.Type.sameFilter, s = new string[] { x3.Key } });


                    foreach (var x2 in x.o.filter)
                        check2(x2.Value, e);
                }

                public void check(error e) => check2(f.f, e);

            }
            public Files f = new Files();


















            public class Data
            {
                public class Calculate
                {
                    public path filter = new path("");                
                }
                public Calculate c = new Calculate();



                public class Out
                {
                    public path dir;
                }
                public Out o = new Out();

            }
            public Data d = new Data();



            public error e = new error();

















            public dir di;


            public void dirSet()
            {
                di = new dir(this);
                di.init(e);
            }


        }

    }
}
