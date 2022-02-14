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


        }
    }
}