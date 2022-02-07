using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;








namespace VisualStudioCppExtensions
{
    namespace filterToDir
    {





        public class filter
        {
            public VCFilter x;

            public path xn;
            public string xn2;
            public string guid;



            public class other
            {
                public filter xp;
                public Dictionary<string, file> files = new Dictionary<string, file>(StringComparer.OrdinalIgnoreCase);
                public HashSet<filter> filters2 = new HashSet<filter>();
            }
            public other o = new other();


            public filter() { }
            public filter(VCFilter x, filter xp) => init(x, xp);



            public void init(VCFilter x, filter xp)
            {
                this.x = x;
                o.xp = xp;
                xn = new path(x.CanonicalName);
                xn2 = x.Name;
                guid = x.UniqueIdentifier;




                foreach (VCFile x2 in (IVCCollection)x.Files)
                {
                    if (x2.ItemType == null) continue;
                    file x3 = new file(x2, this);
                    o.files.Add(x3.x2.x, x3);
                }


                foreach (VCFilter x2 in (IVCCollection)x.Filters)
                {
                    filter x3 = new filter(x2, this);
                    o.filters2.Add(x3);
                }
            }
        }























        public class filters2
        {
            public VCProject p;
            public filter f;




            public void init(VCProject p)
            {
                this.p = p;
                f = new filter();


                foreach (VCFile x2 in (IVCCollection)p.Files)
                {
                    if (!(x2.Parent is VCProject)) continue;
                    if (x2.ItemType == null) continue;

                    file x3 = new file(x2, f);
                    f.o.files.Add(x3.x2.x, x3);
                }


                foreach (VCFilter x2 in (IVCCollection)p.Filters)
                {
                    if (!(x2.Parent is VCProject)) continue;

                    filter x3 = new filter(x2, f);
                    f.o.filters2.Add(x3);
                }
            }







            /*public void fCleanEmpty(Dictionary<string, VCFile> filesIn, bool fEmptyDelete)
            {
                //remove from filters2
                foreach (var v in filesIn)
                {
                    object o = v.Value.Parent;
                    if (!(o is VCFilter)) continue;
                    VCFilter f = (VCFilter)o;
                    fAll[f.CanonicalName].files.Remove(v.Value.FullPath);
                    v.Value.Move(p);
                }

                //filters2 clean
                bool b;
                do
                {
                    b = false;
                    fAll = fAll.Where(x =>
                    {
                        filter2 x2 = x.Value;
                        if (x2.files.Count != 0) return true;
                        if (x2.filters2.Count != 0) return true;
                        if (!fEmptyDelete) if (x2.fEmpty) return true;
                        filter2 xp = x2.xp;
                        xp.filters2.Remove(x2.xn2);
                        x2.x.Remove();
                        b = true;
                        return false;
                    }
                    ).ToDictionary(x => x.Key, x => x.Value);
                } while (b);

            }*/







            /*public filter2 fAdd(filter2 f, string x)
            {
                path x2 = new path(x, path.Separator.sDefault);


                filter2 x3 = f;
                for (int i = 0; i < x2.x2.Length; i++)
                {
                    if (!x3.filters2.TryGetValue(x2.x2[i], out filter2 x4))
                    {
                        VCFilter x5 = null;
                        if (x3.x == null)
                            x5 = (VCFilter)p.AddFilter(x2.x2[i]);
                        else
                            x5 = (VCFilter)x3.x.AddFilter(x2.x2[i]);

                        x4 = new filter2() { x = x5 };
                        x4.xp = x3;
                        x3.filters2.Add(x5.Name, x4);
                        fAll.Add(x5.CanonicalName, x4);

                        x4.xn = x5.CanonicalName;
                        x4.xn2 = x5.Name;
                    }
                    x3 = x4;
                }
                return x3;
            }*/



        }
    }
}