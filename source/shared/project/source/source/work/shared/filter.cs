using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using u.other;

namespace VisualStudioCppExtensions
{
    namespace shared
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
                public Dictionary<string, file> file = new Dictionary<string, file>(StringComparer.OrdinalIgnoreCase);
                public Dictionary<string, filter> filter = new Dictionary<string, filter>(StringComparer.OrdinalIgnoreCase);
                public bool fEmpty = false;
            }
            public other o = new other();


            public filter() { }
            public filter(VCFilter x, filter xp, filters.All a) => init(x, xp, a);



            public void init(VCFilter x, filter xp, filters.All a)
            {
                this.x = x;
                o.xp = xp;
                xn = new path(x.CanonicalName);
                xn2 = x.Name;
                guid = x.UniqueIdentifier;




                foreach (VCFile x2 in (IVCCollection)x.Files)
                {
                    if (x2.ItemType == null) continue;          //proveriti
                    file x3 = new file(x2, this);
                    o.file.Add(x3.xn.x, x3);
                    a.file.Add(x3.xn.x, x3);
                }


                foreach (VCFilter x2 in (IVCCollection)x.Filters)
                {
                    filter x3 = new filter(x2, this, a);
                    o.filter.Add(x3.xn2, x3);
                    a.filter.Add(x3.xn.x, x3);
                }

                o.fEmpty = (o.file.Count == 0 && o.filter.Count == 0);
            }






            public void initRoot(VCProject p, filters.All a)
            {
                foreach (VCFile x2 in (IVCCollection)p.Files)
                {
                    if (!(x2.Parent is VCProject)) continue;
                    if (x2.ItemType == null) continue;          //proveriti

                    file x3 = new file(x2, this);
                    o.file.Add(x3.xn.x, x3);
                    a.file.Add(x3.xn.x, x3);
                }


                foreach (VCFilter x2 in (IVCCollection)p.Filters)
                {
                    if (!(x2.Parent is VCProject)) continue;

                    filter x3 = new filter(x2, this, a);
                    o.filter.Add(x3.xn2, x3);
                    a.filter.Add(x3.xn.x, x3);
                }
            }
        }


































        public class filters
        {
            public VCProject p;
            public filter f;


            public class All
            {
                public Dictionary<string, file> file = new Dictionary<string, file>(StringComparer.OrdinalIgnoreCase);
                public Dictionary<string, filter> filter = new Dictionary<string, filter>(StringComparer.OrdinalIgnoreCase);
            }
            public All a = new All();



            private void init2(VCProject p, error e)
            {
                this.p = p;

                f = new filter();
                f.initRoot(p, a);


                //check
                {
                    List<string> x = new List<string>();

                    foreach (VCFile x2 in (IVCCollection)p.Files)
                        if (x2.ItemType != null)
                            if (!a.file.ContainsKey(x2.FullPath)) x.Add(x2.FullPath);

                    foreach (VCFilter x2 in (IVCCollection)p.Filters)
                        if (!a.filter.ContainsKey(x2.CanonicalName)) x.Add(x2.CanonicalName);

                    if (x.Count != 0) e.add(new error.data() { t = error.Type.projectItemMissing, s = x.ToArray() });
                }
            }

















            public void init(shared.Project p, error e)
            {
                VCReferences xr = (VCReferences)p.p.VCReferences;
                HashSet<string> xp = new HashSet<string>();


                if (!p.flagVcxItems)
                {
                    //reference   search
                    foreach (VCSharedProjectReference x in xr.GetReferencesOfType(32))
                        xp.Add(((EnvDTE.Project)x.ReferencedProject).FullName);

                    //reference   remove
                    foreach (VCSharedProjectReference x in xr.GetReferencesOfType(32))
                        xr.RemoveReference(x);
                }



                //projectItems
                init2(p.p, e);



                if (!p.flagVcxItems)
                {
                    //reference   add
                    bool x3;
                    foreach (string x in xp)
                        xr.AddSharedProjectReference(x, out x3);
                }
            }






        }
    }
}