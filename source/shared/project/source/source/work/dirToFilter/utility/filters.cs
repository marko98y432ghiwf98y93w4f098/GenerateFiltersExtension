using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using VisualStudioCppExtensions.shared;
using u.other;



namespace VisualStudioCppExtensions
{
    namespace dirToFilter
    {




        public class filters2
        {

            public filters f;
            public filter fRoot;
            


            public void init(shared.Project p, error e)
            {
                f = new filters();
                f.init(p, e);
            }







            public void fDeleteEmpty(Dictionary<string, file> filesIn, bool fEmptyDelete)
            {
                //remove from filters
                foreach (var v in filesIn)
                {
                    file f = v.Value;
                    filter f2 = f.xp;
                    f2.o.file.Remove(f.xn.x);
                    f.x.Move(this.f.p);
                }

                //filters clean
                bool b;
                do
                {
                    b = false;
                    f.a.filter = f.a.filter.Where(x =>
                    {
                        filter x2 = x.Value;
                        if (x2.o.file.Count != 0) return true;
                        if (x2.o.filter.Count != 0) return true;
                        if (!fEmptyDelete) if (x2.o.fEmpty) return true;
                        x2.o.xp.o.filter.Remove(x2.xn2);
                        x2.x.Remove();
                        b = true;
                        return false;
                    }
                    ).ToDictionary(x => x.Key, x => x.Value);
                } while (b);

            }







            public filter fAdd(filter f, string x)
            {
                if (x == null) return f;
                path x2 = new path(x, path.separator.sDefault);


                filter x3 = f;
                foreach (string s in x2.x2)
                {
                    if (!x3.o.filter.TryGetValue(s, out filter x4))
                    {
                        x4 = new filter((VCFilter)((x3.x == null) ? this.f.p.AddFilter(s) : x3.x.AddFilter(s)), x3, this.f.a);
                        x3.o.filter.Add(x4.xn2, x4);
                        this.f.a.filter.Add(x4.xn.x, x4);
                    }
                    x3 = x4;
                }
                return x3;
            }






            public void fAdd(Dictionary<string, file> x, path dRoot)
            {
                foreach (var v in x)
                {
                    file x2 = v.Value;
                    path xn = (x2.xn - dRoot)?.mUp();
                    if (xn == null) continue;

                    filter x3 = fAdd(fRoot, xn.x);
                    
                    x2.x.Move(x3.x ?? (object)f.p);
                    x3.o.file.Add(x2.xn.x, x2);
                }
            }























            public static void filtersDeleteAll(VCProject p2)
            {
                {
                    LinkedList<VCFile> x = new LinkedList<VCFile>();
                    foreach (VCFile x2 in (IVCCollection)p2.Files)
                        x.AddLast(x2);

                    foreach (VCFile x2 in x)
                        x2.Move(p2);
                }

                {
                    LinkedList<VCFilter> x = new LinkedList<VCFilter>();
                    foreach (VCFilter x2 in (IVCCollection)p2.Filters)
                        x.AddLast(x2);

                    foreach (VCFilter x2 in x)
                        if (x2.Parent is VCProject)
                            p2.RemoveFilter(x2);
                }
            }



        }
    }
}