using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using u.api;

namespace u.forms.form
{
    public class form2 : Form
    {
        [DllImport("user32.dll", EntryPoint = "MoveWindow")] private static extern bool MoveWindow(nint id, int x, int y, int x2, int y2, bool repaint);
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)          //clientSize,   formBorderStyle,   scaleControl,   size,   showDialog
        {
            base.SetBoundsCore(x, y, width, height, specified);
            if (this.Width != width || this.Height != height)
                MoveWindow(this.Handle, x, y, width, height, true);

            /*Size s1 = this.Size;
            Size s2 = this.ClientSize;

            SizeF s3 = this.AutoScaleDimensions;
            SizeF s4 = this.CurrentAutoScaleDimensions;
            var s5 = this.AutoScaleBaseSize;
            SizeF s6 = this.AutoScaleFactor;
            var s7 = this.AutoScaleMode;

            int s8 = this.DeviceDpi;*/

            //SystemInformation.dpi
            //var s9 = Application.HighDpiMode;
        }



















































        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)          //scale,          //resumeLayout
        {
            base.ScaleControl(factor, specified);
        }

        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)          //getScaledBounds          //scaleControl
        {
            return base.GetScaledBounds(bounds, factor, specified);
        }

        protected override void ScaleCore(float x, float y)
        {
            base.ScaleCore(x, y);
        }

        /*protected override void ScaleMinMaxSize(float xScaleFactor, float yScaleFactor, bool updateContainerSize = true)
        {
            base.ScaleMinMaxSize(xScaleFactor, yScaleFactor, updateContainerSize);
        }*/














































        protected override void OnDpiChanged(DpiChangedEventArgs e)          //dpi
        {
            base.OnDpiChanged(e);
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
        }

        protected override void OnDpiChangedBeforeParent(EventArgs e)
        {
            base.OnDpiChangedBeforeParent(e);
        }

        protected override bool OnGetDpiScaledSize(int deviceDpiOld, int deviceDpiNew, ref Size desiredSize)
        {
            //desiredSize = this.Size;
            return base.OnGetDpiScaledSize(deviceDpiOld, deviceDpiNew, ref desiredSize);
            //return true;
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            return base.PreProcessMessage(ref msg);
        }

























































        public class message
        {
            public class nc
            {
                public enum x
                {
                    create = 0x081,
                    destroy = 0x082,
                    sizeGet = 0x083,
                    testHit = 0x084,
                    paint = 0x085,
                    activate = 0x086,
                }

                public enum mouse
                {
                    move = 0x0a0,
                    bld = 0x0a1,
                    blu = 0x0a2,
                    blc2 = 0x0a3,
                    brd = 0x0a4,
                    bru = 0x0a5,
                    brc2 = 0x0a6,
                    bmd = 0x0a7,
                    bmu = 0x0a8,
                    bmc2 = 0x0a9,
                    bxd = 0x0ab,
                    bxu = 0x0ac,
                    bxc2 = 0x0ad,

                    Hover = 0x02a0,
                    Leave = 0x02a2,
                }

                public enum other
                {
                    dwmNcRenderingChanged = 0x031f,
                }
            }
        }




        /*public class flag
        {
            public bool draw = true;
        }
        public flag f = new();*/

        protected override void WndProc(ref Message m)
        {
            /*if (m.Msg == (int)message.nc.x.create)
            {
                //w32.dpi.f.other.EnableNonClientDpiScaling(this.Handle);
                DefWndProc(ref m);
                return;
            }*/

            //if (!f.draw && (m.Msg == (int)w32.other.message.paint /*|| m.Msg == (int)w32.other.message.paintNc*/)) return;

            base.WndProc(ref m);
        }























        public form2()
        {
            this.MaximumSize = new(7000, 7000);
            this.AutoScaleMode = AutoScaleMode.None;
        }
    }
}