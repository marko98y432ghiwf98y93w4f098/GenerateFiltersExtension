﻿using System;
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
            

            public partial class dir
            {
                public ProjectData p;
                public path root;


                public dir(ProjectData p) => this.p = p;










                public void init(error e)
                {
                    root = p.d.o.dir;
                    if (!Directory.Exists(root.x)) throw new Exception();


                    //file   get
                    file2[] x = null;
                    {
                        LinkedList<file2> x1 = new LinkedList<file2>();
                        file2.filesGet(root, p.f.f.f, ref x1);
                        x = x1.ToArray();
                    }


                    //dir   get(source),   create(destionation)
                    HashSet<dir2> x2 = new HashSet<dir2>();
                    foreach (file2 x3 in x)
                    {
                        x2.Add(new dir2() { d = x3.f.xn.mUp() });
                        x3.createMoveD();
                    }



                    //file   move
                    do
                    {
                        int x3 = x.Length;
                        x = x.Where(x4 => !x4.move(p, e)).ToArray();
                        if (x3 == x.Length) break;
                    } while (true);
                    //error
                    foreach (file2 x3 in x)
                        e.add(new error.data() { t = error.Type.move, s = new string[] { x3.p1.x, x3.p2.x } });



                    //dir   delete
                    foreach (dir2 x3 in x2)
                        x3.info();
                    x2 = x2.Where(x3 => x3.r.files == 0).ToHashSet();

                    do
                    {
                        int x3 = x2.Count;
                        foreach (dir2 x4 in x2.Where(x4 => x4.r.dirs == 0))
                        {
                            dir2.delete(x4.d, e);
                            dir2.deleteUp(root, x4.d.mUp(), e);
                        }

                        x2 = x2.Where(x4 => x4.r.dirs != 0).ToHashSet();

                        x2 = x2.Where(x4 => x4.info()).ToHashSet();

                        if (x3 == x2.Count) break;
                    } while (true);



                    //dir   deleteDown
                    foreach (dir2 x3 in x2) { dir2.deleteDown(root, x3.d, e); dir2.deleteUp(root, x3.d.mUp(), e); }
                }



            }
            



        }

    }
}
