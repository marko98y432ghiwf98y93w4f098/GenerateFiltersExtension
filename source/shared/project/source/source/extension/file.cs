using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualStudioCppExtensions
{

    public class file
    {
        public VCFile x;
        public path xn;
        public path fn;

        public void init(VCFile x)
        {
            this.x = x;
            xn = new path();
            xn.init(x.FullPath, path.seperatorDir);
        }

        public void init(string p)
        {
            path pn = new path();
            {
                pn.init(p, path.seperatorDir);
                if (pn.x2.Length > xn.x2.Length) return;
            }

            int i = 0;
            {
                int i2 = pn.x2.Length;
                for (; i < i2; i++)
                    if (string.Compare(pn.x2[i], xn.x2[i], StringComparison.OrdinalIgnoreCase) != 0) break;

                if (i != pn.x2.Length) return;
            }

            {
                string s = "";
                if (i < xn.x2.Length - 1)
                    s = string.Join("\\", xn.x2, i, xn.x2.Length - 1 - i);

                fn = new path();
                fn.init(s, new char[] { '\\' });
            }


        }







    }





    public class path
    {
        public string x;
        public string[] x2;

        public static char[] seperatorDir = new char[] { System.IO.Path.DirectorySeparatorChar };


        public void init(string x, char[] separator)
        {
            this.x = x;
            x2 = new string[0];
            if (x != null)
                x2 = x.Split(separator, StringSplitOptions.RemoveEmptyEntries);


            /*
            new char[] { System.IO.Path.DirectorySeparatorChar }
            DirectorySeparatorChar
            AltDirectorySeparatorChar
            PathSeparator
            VolumeSeparatorChar
            */


        }

    }




}