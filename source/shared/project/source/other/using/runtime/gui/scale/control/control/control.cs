using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace u.forms.scale.control
{


    public partial class control
    {
        private static Dictionary<Control, control> d = new();          //static
        public static IReadOnlyDictionary<Control, control> d2 => d;

        public static control c(Control c)
        {
            control f()
            {
                if (!d.TryGetValue(c, out control x)) d.Add(c, x = new());
                return x;
            }
            control x = f();
            x.init(c);
            return x;
        }

        public static void c2(Control c) => d.Remove(c);

        /*public static void info()
        {
            int x = d.Count;
        }*/
        























        public class scale
        {
            public data[] x;
            public double[] xs = new double[2] { 1, 1 };
            public s.value[] v = new s.value[2];
        }
        public scale s = new();


        public Control xc;
































        private control() { }

        private void init(Control c)
        {
            this.xc ??= c;
            this.a.c ??= c;

            if (s.x == null)
            {
                s.x = new data[5];
                init1();
            }
        }

        public void init1()
        {
            s.x[0].load(this);
            s.x[1] = s.x[0];
            return;
        }


        public void init2()
        {
            var v = s.v[0];
            if (v != null)
            {
                data[] d = new data[2];
                d[0].load(this);
                d[1] = d[0].scale(xc, v.rec());
                //bool bf = xc is Form xc2 && xc2.Parent == null || true;

                /*bool b = xc is Form xc2 && xc2.Parent == null;
                if (b)
                {
                    if (((Form)xc).Location != d[0].x.x)
                        throw new();
                    if (((Form)xc).Location != d[1].x.x)
                        throw new();
                }*/


                bool f<T>(ref T x, T y) where T : struct
                {
                    bool b = !x.Equals(y);
                    if (b) x = y;
                    return b;
                }

                /*if (b)
                {
                    s.x[2].x.x = d[0].x.x;
                    s.x[1].x.x = d[1].x.x;
                }
                else*/
                if (f(ref s.x[2].x.x, d[0].x.x))
                    s.x[1].x.x = d[1].x.x;

                if (f(ref s.x[2].x.x2.s, d[0].x.x2.s))          //&& bf)
                    s.x[1].x.x2.s = d[1].x.x2.s;
                if (f(ref s.x[2].x.x2.s2, d[0].x.x2.s2))          //&& bf)
                    s.x[1].x.x2.s2 = d[1].x.x2.s2;
                if (f(ref s.x[2].x.x2.sMin, d[0].x.x2.sMin))
                    s.x[1].x.x2.sMin = d[1].x.x2.sMin;
                if (f(ref s.x[2].x.x2.sMax, d[0].x.x2.sMax))
                    s.x[1].x.x2.sMax = d[1].x.x2.sMax;

                if (f(ref s.x[2].x.x3.sPadding, d[0].x.x3.sPadding))
                    s.x[1].x.x3.sPadding = d[1].x.x3.sPadding;
                if (f(ref s.x[2].x.x3.sMargin, d[0].x.x3.sMargin))
                    s.x[1].x.x3.sMargin = d[1].x.x3.sMargin;

                if (!s.x[2].x.x4.f.compare(d[0].x.x4.f.x))
                {
                    s.x[2].x.x4.f = d[0].x.x4.f;
                    s.x[1].x.x4.f = d[1].x.x4.f;
                }


                if (xc is SplitContainer x2)          //splitContainer.distance
                {
                    bool f2()
                    {
                        foreach (Control x3 in x2.Panel1.Controls)
                            if (x3.Dock == DockStyle.Fill) return false;
                        return true;
                    }
                    if (f2())
                        if ((int)s.x[2].x.x4.x[0] != (int)d[0].x.x4.x[0])
                            s.x[1].x.x4.x = d[1].x.x4.x;
                }
            }
        }
    }
}