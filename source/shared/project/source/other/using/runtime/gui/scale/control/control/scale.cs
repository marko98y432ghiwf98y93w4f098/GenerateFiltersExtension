using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;
using value = u.forms.scale.s.value;

namespace u.forms.scale.control
{


    public partial class control
    {








        public struct data
        {
            public (Point x,
             (Size s, Size s2, Size sMin, Size sMax) x2,
             (Padding sPadding, Padding sMargin) x3,
             (font f, object[] x) x4) x;









            public void load(control c2)
            {
                Control c = c2.xc;


                /*if (c is Form c4 && c4.Parent == null)
                {

                }*/



                x.x = c2.a.l;
                x.x2.s = c2.a.s;
                x.x2.s2 = c2.a.s2;
                x.x2.sMin = c.MinimumSize;
                x.x2.sMax = c.MaximumSize;
                x.x3.sPadding = c.Padding;
                x.x3.sMargin = c.Margin;


                x.x4.f = new(c.Font);
                if (c is SplitContainer c5)
                    x.x4.x = new object[] { c5.SplitterDistance };


                /*if (c is Form c3 && c3.Parent == null)
                {
                    if (c3.Location != x.x)
                    {

                    }
                }*/
            }


















            public void save(control c2)
            {
                Control c = c2.xc;

                ref data x3 = ref this;
                {
                    if (c is Form c3) c3.AutoScale = false;
                    if (c is ContainerControl c4) c4.AutoScaleMode = AutoScaleMode.None;

                    var a2 = c.AutoSize;
                    c.AutoSize = false;          //form,   label,   textBox


                    var a = c.Anchor;
                    c.Anchor = AnchorStyles.Top | AnchorStyles.Left;


                    //if (c is Label cl) { ContentAlignment a3 = cl.TextAlign; cl.TextAlign = ContentAlignment.TopLeft; }







                    {
                        c.MaximumSize = x3.x.x2.sMax;
                        c.MinimumSize = x3.x.x2.sMin;

                        c.Padding = x3.x.x3.sPadding;          //scale          padding
                        c.Margin = x3.x.x3.sMargin;          //scale          padding


                        c2.a.l = x3.x.x;          //scale          point

                        c2.a.s = x3.x.x2.s;          //scale          size
                                                     //w32.other.MoveWindow(c.Handle, x3.x.x.X, x3.x.x.Y, x3.x.x2.s.Width, x3.x.x2.s.Height, false);


                        c.Font = x3.x.x4.f.toFont();          //scale          font
                    }







                    if (c is Label cl2) { /*cl2.TextAlign = a3;*/ cl2.xSize(); }

                    c.Anchor = a;
                    c.AutoSize = a2;
                }










                {
                    if (c is SplitContainer x2)          //splitContainer.distance
                    {
                        bool f2()
                        {
                            foreach (Control x3 in x2.Panel1.Controls)
                                if (x3.Dock == DockStyle.Fill) return false;
                            return true;
                        }
                        if (f2())
                            x2.SplitterDistance = (int)x3.x.x4.x[0];          //scale          int
                    }

                    //if (c is RadioButton) goto exit;
                    //if (c is CheckBox) goto exit;
                }
            }











































            public data scale(Control c, value v, value v0 = null, Point? p = null)
            {
                data d2 = new();

                {
                    {
                        Size s2 = x.x2.s - x.x2.s2;          //size
                        Size f3(Size s)
                        {
                            Size s3 = v.f(s - s2) + s2;          //scale          size
                            if (s.Width == 0 || s3.Width < 0) s3.Width = 0;
                            if (s.Height == 0 || s3.Height < 0) s3.Height = 0;
                            return s3;
                        }


                        d2.x.x2.sMax = f3(x.x2.sMax);
                        d2.x.x2.sMin = f3(x.x2.sMin);

                        d2.x.x3.sPadding = v.f(x.x3.sPadding);          //scale          padding
                        d2.x.x3.sMargin = v.f(x.x3.sMargin);          //scale          padding


                        if (c is Form c2 && c2.Parent == null)          //scale          point
                        {
                            /*if (c2.Location != x.x)
                            {

                            }*/

                            if (p == null)
                            {
                                d2.x.x = x.x;
                            }
                            else
                            {
                                var p2 = p.Value - (Size)c2.Location;          //x.x;
                                if (v0 != null)
                                    p2 = v0.rec().f(p2);
                                //else
                                    //throw new();
                                d2.x.x = p.Value - (Size)v.f(p2);
                            }
                        }
                        else
                            d2.x.x = v.f(x.x);

                        if (c is Form)          //scale          size
                            d2.x.x2.s = f3(x.x2.s);
                        else
                            d2.x.x2.s = v.f(x.x2.s);
                        d2.x.x2.s2 = v.f(x.x2.s2);


                        d2.x.x4.f = v.f(x.x4.f, c);          //scale          font
                    }






                    if (c is SplitContainer x2)          //splitContainer.distance
                    {
                        bool f2()
                        {
                            foreach (Control x3 in x2.Panel1.Controls)
                                if (x3.Dock == DockStyle.Fill) return false;
                            return true;
                        }
                        if (f2())
                            d2.x.x4.x = new object[] { v.f((int)x.x4.x[0]) };          //scale          int
                    }
                }

                return d2;
            }
        }
    }

}