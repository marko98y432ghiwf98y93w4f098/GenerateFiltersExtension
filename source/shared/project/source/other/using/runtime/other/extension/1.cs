using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;


namespace u
{
    public static partial class xCommon
    {
        public static bool xE(this string s) => string.IsNullOrEmpty(s);          //string
        public static bool xE2(this string x) => string.IsNullOrWhiteSpace(x);


        public static string xE(this string s, string s2) => string.IsNullOrEmpty(s) ? "" : s + s2;


        public static bool xC(this string x, string x2) => string.Equals(x, x2, StringComparison.Ordinal);
        
        public static bool xC2(this string x, string x2) => string.Equals(x, x2, StringComparison.OrdinalIgnoreCase);
















        public static string xS(this bool x) => x ? "true" : "false";          //bool
        public static string xS2(this bool x) => x ? "true" : "";




        public static bool x(this bool? x2) => x2 != null && x2 == true;          //bool?











        public static bool xEmpty(this Array x) => x == null || x.Length == 0;          //array
        public static void xNew(this Array x)
        {
            if (x.xEmpty()) return;
           
            Type t = x.GetType().GetElementType();
            var t2 = t.GetConstructor(Type.EmptyTypes);

            int x2 = x.Length;
            for (int i = 0; i < x2; i++)
                x.SetValue(t2.Invoke(null), i);
        }


        








        public static void xFor<T>(this IEnumerable<T> x, Action<T> x2) { foreach (T x3 in x) x2(x3); }          //collection














        public static string xS(this Enum x) => x.ToString();          //enum




        /*public static void set<T>(this ref T x, T x2, bool b) where T : struct          //p   ne menja valueType
        {
            try
            {
                Type t = x.GetType();
                TypeCode t2 = Type.GetTypeCode(Enum.GetUnderlyingType(t));
                dynamic y = Convert.ChangeType(x, t2);
                dynamic y2 = Convert.ChangeType(x2, t2);
                if (b)
                    y |= y2;
                else
                    y &= ~y2;
                x = (T)y;
            }
            catch(Exception e)
            {

            }
        }*/

        /*public static bool get(this Enum x, Enum x2)
        {
            try
            {
                TypeCode t = Type.GetTypeCode(Enum.GetUnderlyingType(x.GetType()));          //popraviti   da li dynamic usporava
                dynamic y = Convert.ChangeType(x, t);
                dynamic y2 = Convert.ChangeType(x2, t);
                if (y2 == 0) return y == y2;
                return (y & y2) == y2;
            }
            catch (Exception e)
            {
                return true;
            }
        }*/























        public static Size xMul(this Size x, double x2)          //size
        {
            x.Width = (int)(x.Width * x2);
            x.Height = (int)(x.Height * x2);
            return x;
        }







        public static Size xSize(this SizeF x)          //sizeF
        {
            Size x2 = new();
            x2.Width = (int)Math.Ceiling(x.Width);
            x2.Height = (int)Math.Ceiling(x.Height);
            return x2;
        }

        public static SizeF xDiv(this SizeF x, SizeF x2)
        {
            x.Width /= x2.Width;
            x.Height /= x2.Height;
            return x;
        }

        public static bool xComS(this Size x, Size x2) => x.Width < x2.Width || x.Height < x2.Height;
    }
}
