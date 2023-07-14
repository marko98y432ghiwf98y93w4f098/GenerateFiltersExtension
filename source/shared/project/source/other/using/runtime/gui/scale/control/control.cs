using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace u.forms
{
    public static partial class S
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


















            public struct scale
            {
                public data x;
                public double xs;
                public void init() { xs = 1; }
            }
            public scale[] x;

            
            public value v;

            public Control xc;



























            private control() { }

            private void init(Control c)
            {
                this.xc ??= c;
                this.a.c ??= c;

                if (x == null)
                {
                    {
                        this.x = new scale[3];
                        for (int i = 0; i < 3; i++) this.x[i].init();
                    }
                    init1();
                }
            }

            public void init1()
            {
                this.x[0].x.load(this);
                x[1] = x[0];
                return;
            }


            public void init2()
            {
                if (v != null)
                {
                    data[] d = new data[2];
                    d[0].load(this);
                    d[1] = d[0].scale(xc, v.rec()/*, null, null, xs2.p*/);
                    bool bf = xc is Form xc2 && xc2.Parent == null || true;

                    if (x[2].x.x.x != d[0].x.x)
                        x[1].x.x.x = d[1].x.x;

                    if (x[2].x.x.x2.s != d[0].x.x2.s && bf)
                        x[1].x.x.x2.s = d[1].x.x2.s;
                    if (x[2].x.x.x2.s2 != d[0].x.x2.s2 && bf)
                        x[1].x.x.x2.s2 = d[1].x.x2.s2;
                    if (x[2].x.x.x2.sMin != d[0].x.x2.sMin)
                        x[1].x.x.x2.sMin = d[1].x.x2.sMin;
                    if (x[2].x.x.x2.sMax != d[0].x.x2.sMax)
                        x[1].x.x.x2.sMax = d[1].x.x2.sMax;

                    if (x[2].x.x.x3.sPadding != d[0].x.x3.sPadding)
                        x[1].x.x.x3.sPadding = d[1].x.x3.sPadding;
                    if (x[2].x.x.x3.sMargin != d[0].x.x3.sMargin)
                        x[1].x.x.x3.sMargin = d[1].x.x3.sMargin;

                    if (!x[2].x.x.x4.f.compare(d[0].x.x4.f.x))
                        x[1].x.x.x4.f = d[1].x.x4.f;


                    if (xc is SplitContainer x2)          //splitContainer.distance
                    {
                        bool f2()
                        {
                            foreach (Control x3 in x2.Panel1.Controls)
                                if (x3.Dock == DockStyle.Fill) return false;
                            return true;
                        }
                        if (f2())
                            if ((int)x[2].x.x.x4.x[0] != (int)d[0].x.x4.x[0])
                                x[1].x.x.x4.x = d[1].x.x4.x;
                    }
                }
            }
        }
    }
}