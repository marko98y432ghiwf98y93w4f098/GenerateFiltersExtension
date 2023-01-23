using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using u.other;

namespace VisualStudioCppExtensions
{
    public static class a
    {
        //array
        public static bool xEmpty(this Array x)
        {
            if (x == null) return true;
            if (x.Length == 0) return true;
            return false;
        }




        //string
        public static bool xC(this string x, string x2) => string.Equals(x, x2, StringComparison.Ordinal);
        public static bool xC2(this string x, string x2) => string.Equals(x, x2, StringComparison.OrdinalIgnoreCase);

        public static bool xEmpty(this string x) => string.IsNullOrWhiteSpace(x);





        //other
        public static bool xNull(this path x)
        {
            if (x == null) return true;
            if (x.x2 == null) return true;
            if (x.x == null) return true;
            return false;
        }

        public static bool xFull(this path x) => !x.x2.xEmpty();
        
        
        
    }
}