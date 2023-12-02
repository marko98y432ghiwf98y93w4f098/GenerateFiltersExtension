using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using u.other;

namespace u.other
{


    public class path
    {
        public string x;
        public string[] x2;



        public class separator
        {
            public char[] s = ss;
            public char s2 = ss2;

            public static char[] ss = new char[] { System.IO.Path.DirectorySeparatorChar, System.IO.Path.AltDirectorySeparatorChar };
            public static char ss2 = System.IO.Path.DirectorySeparatorChar;
            public static separator sDefault = new() { s = new char[] { '\\', '/' }, s2 = '\\' };
        }
        public separator s = new();










































        public path(string x = null, separator s = null)
        {
            this.s = s ?? new();
            if (x != null) init(x);
        }

        public path(string[] x2, separator s = null)
        {
            this.s = s ?? new();
            this.x2 = x2;
            if (x2 != null) xJoin();
        }


        private path init(string x)
        {
            x2 = new string[0];
            if (x != null)
                x2 = x.Split(s.s, StringSplitOptions.RemoveEmptyEntries).Select(x3 => x3.Trim()).Where(x3 => !x3.xE2()).ToArray();
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






        static separator oInit(path x1, path x2, separator s = null)
        {
            if (x1.xNull()) return null;
            if (x2.xNull()) return null;
            s ??= new();
            return s;
        }

        static int oCommon2(path x1, path x2)
        {
            int i = 0;
            {
                int i1 = Math.Min(x1.x2.Length, x2.x2.Length);
                for (; i < i1; i++)
                    if (string.Compare(x1.x2[i], x2.x2[i], StringComparison.OrdinalIgnoreCase) != 0) break;
            }
            return i;
        }









        public static path oPlus(path x1, path x2, separator s = null)
        {
            if ((s = oInit(x1, x2, s)) == null) return null;

            return new path(x1.x2.Concat(x2.x2).ToArray(), s);
        }


        public static path oPlus(path x1, string x2, separator s = null)
        {
            if (x1.xNull()) return null;
            if (x2.xE2()) return new path(x1.x2, x1.s);          //clone
            s ??= new();

            return new path(x1.x2.Append(x2).ToArray(), s);
        }


        public static path oMinus(path x1, path x2, separator s = null)
        {
            if ((s = oInit(x1, x2, s)) == null) return null;

            if (!(x1.x2.Length >= x2.x2.Length)) return null;

            if (oCommon2(x1, x2) < x2.x2.Length) return null;

            return new path(x1.x2.Skip(x2.x2.Length).ToArray(), s);
        }








        public static path oCommon(path x1, path x2, separator s = null)          //common
        {
            if ((s = oInit(x1, x2, s)) == null) return null;

            return new path(x1.x2.Take(oCommon2(x1, x2)).ToArray(), s);
        }


        public static path oCommon(string[] p, separator s = null)
        {
            if (p.xEmpty()) return null;          //check
            s ??= new();



            path x = null;
            foreach (string p2 in p)
            {
                if (x == null)
                {
                    x = (new path(p2, s)).mUp();
                    continue;
                }
                x = oCommon(x, new path(p2, s).mUp(), s);
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


































        public override int GetHashCode() => x?.ToLower().GetHashCode() ?? 0;          //interface

        public override bool Equals(object x) => x != null && x is path x2 && path.oEqual(this, x2);

        public override string ToString() => x;
    }
}
















































namespace u
{
    public static class xPath
    {
        public static bool xNull(this path x) => x == null || x.x2 == null || x.x == null;          //extension

        public static bool xFull(this path x) => !x?.x2.xEmpty() ?? false;
    }
}