using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Markup;
using u.forms.scale.control;
using align = u.forms.scale.control.control.position.align;

namespace u.forms.control
{


    public class label2 : Label          //label
    {
        public label2()
        {
            base.AutoSize = false;
            this.SetStyle(/*ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque |*/ ControlStyles.OptimizedDoubleBuffer /*| ControlStyles.UserPaint*/, true);
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }



















        static Dictionary<ContentAlignment, (align.a x, align.a y)> textAlign2 = new()          //align
        {
            { ContentAlignment.TopLeft, (align.a.l, align.a.l) },
            { ContentAlignment.TopCenter, (align.a.m, align.a.l) },
            { ContentAlignment.TopRight, (align.a.r, align.a.l) },

            { ContentAlignment.MiddleLeft, (align.a.l, align.a.m) },
            { ContentAlignment.MiddleCenter, (align.a.m, align.a.m) },
            { ContentAlignment.MiddleRight, (align.a.r, align.a.m) },

            { ContentAlignment.BottomLeft, (align.a.l, align.a.r) },
            { ContentAlignment.BottomCenter, (align.a.m, align.a.r) },
            { ContentAlignment.BottomRight, (align.a.r, align.a.r) },
        };

        public override ContentAlignment TextAlign
        {
            get => base.TextAlign;

            set
            {
                base.TextAlign = value;


                {
                    var c = this.xControl();
                    var a = c.a.a;
                    var x = textAlign2[value];
                    a.x = x.x;
                    a.y = x.y;
                    c.init1();
                }


                /*if (d == null) return;
                if (d.t2) { var d2 = d.t; d = null; this.Text = d2; }
                d = null;*/
            }
        }























        /*private class Data          //text
        {
            public string t;
            public bool t2;
        }
        private Data d = new();

        public override string Text
        {
            get => (d?.t2).x() ? d.t : base.Text;

            set
            {
                if (d != null)
                {
                    d.t = value;
                    d.t2 = true;
                    return;
                }

                base.Text = value;
                this.xSize();
            }
        }*/
    }
}












































































namespace u.forms
{
    public static partial class xCommon
    {
        public static void xSize(this Label x)          //label
        {
            if (x == null) return;
            string x2 = x.Text;
            var a = x.xControl().a;
            












            //using StringFormat s = u.forms.other.stringFormat.x2;
            using var g = x.CreateGraphics();
            //g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;


            //SizeF x3 = (x2 != null) ? g.MeasureString(x2 + 'x', x.Font, 0, s) : new();

            SizeF x3 = (x2 != null) ? TextRenderer.MeasureText(g, x2 /*+ 'x'*/, x.Font, new(), TextFormatFlags.SingleLine | TextFormatFlags.NoClipping /*| TextFormatFlags.NoPadding*/ | TextFormatFlags.NoPrefix | TextFormatFlags.PreserveGraphicsTranslateTransform) : new();













            //if (x3.Height != 0) x3.Height += 5;
            //x3 = x3.xDiv(new(96.0f / g.DpiX, 96.0f / g.DpiY));





            /*Size x4 = x3.xSize() - x.Size;
            Size x5 = x4.xMul(0.5);

            if ((x.TextAlign & (ContentAlignment.BottomCenter | ContentAlignment.MiddleCenter | ContentAlignment.TopCenter)) != 0)          //x
                x.Left -= x5.Width;

            if ((x.TextAlign & (ContentAlignment.BottomRight | ContentAlignment.MiddleRight | ContentAlignment.TopRight)) != 0)
                x.Left -= x4.Width;

            if ((x.TextAlign & (ContentAlignment.MiddleLeft | ContentAlignment.MiddleCenter | ContentAlignment.MiddleRight)) != 0)          //y
                x.Top -= x5.Height;

            if ((x.TextAlign & (ContentAlignment.BottomLeft | ContentAlignment.BottomCenter | ContentAlignment.BottomRight)) != 0)
                x.Top -= x4.Height;

            x.Size = x3.xSize();*/

            //x.BackColor = System.Drawing.Color.BlueViolet;













            
            a.s = x3.xSize();
        }
    }
}