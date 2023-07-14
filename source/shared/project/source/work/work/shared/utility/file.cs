using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using u.other;

namespace extension
{
    namespace shared
    {
        public class @file
        {
            public VCFile x;

            public path xn;

            public filter xp;





            public @file(VCFile x, filter xp) => init(x, xp);

            public void init(VCFile x, filter xp)
            {
                this.x = x;
                xn = new path(x.FullPath);
                this.xp = xp;
            }
        }
    }
}