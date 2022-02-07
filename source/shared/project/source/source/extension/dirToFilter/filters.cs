using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;








namespace VisualStudioCppExtensions
{
    namespace dirToFilter
    {





        public class filter
        {
            public filter xp;
            public VCFilter x;
            public string xn;
            public string xn2;
            public Dictionary<string, VCFile> files = new Dictionary<string, VCFile>(StringComparer.OrdinalIgnoreCase);
            public Dictionary<string, filter> filters = new Dictionary<string, filter>(StringComparer.OrdinalIgnoreCase);
            public bool fEmpty = false;

            public void init(Dictionary<string, filter> fAll)
            {



                xn = x.CanonicalName;
                xn2 = x.Name;


                foreach (VCFile x2 in (IVCCollection)x.Files)
                    files.Add(x2.FullPath, x2);


                foreach (VCFilter x2 in (IVCCollection)x.Filters)
                {
                    filter x3 = fAll[x2.CanonicalName];
                    x3.xp = this;
                    filters.Add(x2.Name, x3);
                }

                if (files.Count == 0 && filters.Count == 0)
                    fEmpty = true;
            }
        }























        public class filters
        {
            public VCProject p2;
            public Dictionary<string, filter> fAll;
            public filter f;
            public filter fRoot;



            public void init(VCProject p2)
            {
                this.p2 = p2;
                fAll = new Dictionary<string, filter>();
                f = new filter();

                foreach (VCFilter x2 in (IVCCollection)p2.Filters)
                {
                    filter x3 = new filter() { x = x2 };
                    if (x2.Parent is VCProject)
                    {
                        x3.xp = f;
                        f.filters.Add(x2.Name, x3);
                    }
                    fAll.Add(x2.CanonicalName, x3);
                }

                foreach (var x2 in fAll)
                    x2.Value.init(fAll);
            }







            public void fCleanEmpty(Dictionary<string, VCFile> filesIn, bool fEmptyDelete)
            {
                //remove from filters
                foreach (var v in filesIn)
                {
                    object o = v.Value.Parent;
                    if (!(o is VCFilter)) continue;
                    VCFilter f = (VCFilter)o;
                    fAll[f.CanonicalName].files.Remove(v.Value.FullPath);
                    v.Value.Move(p2);
                }

                //filters clean
                bool b;
                do
                {
                    b = false;
                    fAll = fAll.Where(x =>
                    {
                        filter x2 = x.Value;
                        if (x2.files.Count != 0) return true;
                        if (x2.filters.Count != 0) return true;
                        if (!fEmptyDelete) if (x2.fEmpty) return true;
                        filter xp = x2.xp;
                        xp.filters.Remove(x2.xn2);
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
                path x2 = new path(x, path.Separator.sDefault);


                filter x3 = f;
                for (int i = 0; i < x2.x2.Length; i++)
                {
                    if (!x3.filters.TryGetValue(x2.x2[i], out filter x4))
                    {
                        VCFilter x5 = null;
                        if (x3.x == null)
                            x5 = (VCFilter)p2.AddFilter(x2.x2[i]);
                        else
                            x5 = (VCFilter)x3.x.AddFilter(x2.x2[i]);

                        x4 = new filter() { x = x5 };
                        x4.xp = x3;
                        x3.filters.Add(x5.Name, x4);
                        fAll.Add(x5.CanonicalName, x4);

                        x4.xn = x5.CanonicalName;
                        x4.xn2 = x5.Name;
                    }
                    x3 = x4;
                }
                return x3;
            }






            public void filtersSet(Dictionary<string, file> x)
            {
                foreach (var v in x)
                {
                    file x2 = v.Value;
                    if (x2.fn == null) continue;

                    filter x3 = fRoot;
                    foreach (string x4 in x2.fn.x2)
                        x3 = fAdd(x3, x4);

                    x2.x.Move(x3.x ?? (object)p2);
                    x3.files.Add(x2.xn.x, x2.x);
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