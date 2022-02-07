using Microsoft.VisualStudio.VCProjectEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VisualStudioCppExtensions
{
    

    public class path
    {
        public string x;
        public string[] x2;



        public class Separator
        {
            public char[] s = ss;
            public char s2 = ss2;

            public static char[] ss = new char[] { System.IO.Path.DirectorySeparatorChar, System.IO.Path.AltDirectorySeparatorChar };
            public static char ss2 = System.IO.Path.DirectorySeparatorChar;
            public static Separator sDefault = new path.Separator() { s = new char[] { '\\', '/' }, s2 = '\\' };
        }
        public Separator s = new Separator();












        public path(string x = null, Separator s = null)
        {
            this.s = s ?? new Separator();
            if (x != null) init(x);
        }

        public path(string[] x2, Separator s = null)
        {
            this.s = s ?? new Separator();
            this.x2 = x2;
            if (x2 != null) xJoin();
        }


        public path init(string x)
        {
            x2 = new string[0];
            if (x != null)
                x2 = x.Split(s.s, StringSplitOptions.RemoveEmptyEntries).Select(x3 => x3.Trim()).Where(x3 => x3.xFull()).ToArray();
            xJoin();

            return this;
        }
















        public string xJoin() => x = string.Join(s.s2.ToString(), x2);






        








        public string sLast { get => x2.xEmpty() ? null : x2[x2.Length - 1]; }
        public int count { get => x2.xEmpty() ? 0 : x2.Length; }














        public static path operator +(path x1, path x2) => path.oPlus(x1, x2);
        public static path operator +(path x1, string x2) => path.oPlus(x1, x2);
        public static path operator -(path x1, path x2) => path.oMinus(x1, x2);
        public static path operator *(path x1, path x2) => path.oCommon(x1, x2);
        /*public static bool operator ==(path x1, path x2) => path.oEqual(x1, x2);
        public static bool operator !=(path x1, path x2) => !path.oEqual(x1, x2);*/


        public static path oPlus(path x1, path x2, Separator s = null)
        {
            if (x1.xNull()) return null;
            if (x2.xNull()) return null;
            if (s == null) s = new Separator();

            return new path(x1.x2.Concat(x2.x2).ToArray(), s);
        }

        public static path oPlus(path x1, string x2, Separator s = null)
        {
            if (x1.xNull()) return null;
            if (!x2.xFull()) return new path(x1.x2, x1.s);          //clone
            if (s == null) s = new Separator();

            return new path(x1.x2.Append(x2).ToArray(), s);
        }



        public static path oMinus(path x1, path x2, Separator s = null)
        {
            if (x1.xNull()) return null;
            if (x2.xNull()) return null;
            if (s == null) s = new Separator();

            if (!(x1.x2.Length >= x2.x2.Length)) return null;

            for (int i = 0; i < x2.x2.Length; i++)
                if (string.Compare(x1.x2[i], x2.x2[i], StringComparison.OrdinalIgnoreCase) != 0) return null;

            return new path(x1.x2.Skip(x2.x2.Length).ToArray(), s);
        }


        



        public static path oCommon(path x1, path x2, Separator s = null)
        {
            //check
            if (x1.xNull()) return null;
            if (x2.xNull()) return null;
            //s ??= new Separator();
            if (s == null) s = new Separator();



            int i = 0;
            {
                int i1 = Math.Min(x1.x2.Length, x2.x2.Length);
                for (; i < i1; i++)
                    if (String.Compare(x1.x2[i], x2.x2[i], StringComparison.OrdinalIgnoreCase) != 0) break;
            }

            return new path(x1.x2.Take(i).ToArray(), s);
        }




        //common
        public static path oCommon(string[] p, Separator s = null)
        {
            //check
            if (p.xEmpty()) return null;
            if (s == null) s = new Separator();

            

            path x = null;
            foreach (string p2 in p)
            {
                if (x == null)
                {
                    x = new path(p2, s);
                    continue;
                }
                x = oCommon(x, new path(p2, s), s);
                if (x == null) break;
                if (x.x2.Length == 0) break;
            }

            return x;
        }





        public static bool oEqual(path x1, path x2)
        {
            bool b1 = !x1.xNull();
            bool b2 = !x2.xNull();
            if (!(b1 || b2)) return true;
            if (b1 ^ b2) return false;
            return x1.x.xC2(x2.x);
        }










        public path mUp()
        {
            if (x2.xEmpty()) return null;
            int i = x2.Length - 1;
            if (i < 0) return null;
            return new path(x2.Take(i).ToArray(), s);
        }












        //interface
        public override int GetHashCode() => x?.ToLower().GetHashCode() ?? 0; 

        public override bool Equals(object x)
        {
            if (x == null) return false;
            if (!(x is path)) return false;
            return path.oEqual(this, (path)x);
        }

        public override string ToString() => x;
    }
}


