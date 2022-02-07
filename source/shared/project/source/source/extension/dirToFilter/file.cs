using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualStudioCppExtensions
{
    namespace dirToFilter
    {

        public class file
        {
            public VCFile x;
            public path xn;
            public path fn;

            public void init(VCFile x)
            {
                this.x = x;
                xn = new path(x.FullPath);
            }

            public void init(string p) => fn = (xn - new path(p))?.mUp();


        }









    }
}