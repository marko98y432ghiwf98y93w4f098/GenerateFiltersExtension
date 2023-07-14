using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.VCProjectEngine;
using System.Threading;
using extension.shared;
using Project = extension.shared.Project;
using u.other;
using System.Collections;

namespace extension
{
    namespace filterToDir
    {
        public partial class ProjectData
        {
            
            public Project p;          //project








            public class Files
            {
                public filters f;

                public void filesGet(ProjectData p)
                {
                    f = new filters();
                    f.init(p.p, p.e);
                }





                 

                public void check(error e)          //check
                {
                    HashSet<char> checkC = Path.GetInvalidPathChars().Union(Path.GetInvalidFileNameChars()).Select(x => char.ToLower(x)).ToHashSet();


                    void check2(filter x, error e)
                    {
                        if (x.xn2 != null)
                            if (x.xn2.ToHashSet().Select(x => char.ToLower(x)).ToHashSet().Overlaps(checkC))          //chars   filter
                                e.add(new error.data() { t = error.Type.dirName, s = new string[] { x.xn.x } });


                        foreach (var x3 in x.o.file.Where(x2 => !File.Exists(x2.Key)))
                            e.add(new error.data() { t = error.Type.existFile, s = new string[] { "path:     " + x3.Key, "filter:   " + dir.file2.fileRelative(x3.Value).x } });          //exist   file


                        foreach (var x3 in x.o.file.GroupBy(x2 => dir.file2.fileRelative(x2.Value).x.ToLower()).Where(x2 => x2.Count() > 1))          //same   file
                            e.add(new error.data() { t = error.Type.sameFile, s = new string[] { x3.Key } });


                        foreach (var x3 in x.o.filter.GroupBy(x2 => x2.Value.xn.x.ToLower()).Where(x2 => x2.Count() > 1))          //same   filter
                            e.add(new error.data() { t = error.Type.sameFilter, s = new string[] { x3.Key } });



                        foreach (var x2 in x.o.filter)
                            check2(x2.Value, e);
                    }

                    check2(f.f, e);
                }

            }
            public Files f = new();


















            public class Data
            {
                public class Calculate
                {
                    public path filter = new("");                
                }
                public Calculate c = new();



                public class Out
                {
                    public path dir;
                }
                public Out o = new();

            }
            public Data d = new();



            public error e = new();

















            public dir di;


            public void dirSet()
            {
                di = new dir(this);
                di.init(e);
            }


        }

    }
}
