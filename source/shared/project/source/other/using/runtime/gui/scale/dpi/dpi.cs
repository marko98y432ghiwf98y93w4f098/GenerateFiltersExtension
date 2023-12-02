using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using u.api;


namespace u.forms.scale
{
    public static class dpi
    {
        public static class f
        {
            //int        cu\control panel\desktop\logPixels
            //int        cu\control panel\desktop\win8DpiScaling          [0, 1]          p2
            //int        cu\control panel\desktop\windowMetrics\appliedDpi          -          win10,   (sign)
            //string     cu\software\microsoft\windows\currentVersion\themeManager\lastLoadedDpi   (sign)
            public static double r
            {
                get
                {
                    var r = Registry.CurrentUser;

                    object f(string x, string x2, Type x3)
                    {
                        var r2 = r.OpenSubKey(x);
                        object v = r2?.GetValue(x2);
                        if (v == null) return v;
                        if (v.GetType() != x3) return null;
                        return v;
                    }

                    object v = f("control panel\\desktop\\windowMetrics", "appliedDpi", typeof(int));
                    if (v != null) return (int)v;

                    if (int.TryParse((string)f("software\\microsoft\\windows\\currentVersion\\themeManager", "lastLoadedDpi", typeof(string)), out int v2))
                        return v2;

                    v = f("control panel\\desktop", "logPixels", typeof(int));
                    if (v != null) return (int)v;

                    return 96.0;
                }
            }

            public static double g(Control x = null)
            {
                using var g = (x ??= new()).CreateGraphics();
                return g.DpiY;
            }

            public static double d(Control x = null) => (x ?? new()).DeviceDpi;
        }














































        public class dpi2
        {
            public class aware
            {
                public w32.dpi.t.dpiAwarenessContext? x1w;          //10.1607
                public w32.dpi.t.dpiAwareness2? x1w2;          //10.1607
                public uint? x1w3;          //10.1803

                public w32.dpi.t.dpiAwarenessContext? x2t;          //10.1607
                public w32.dpi.t.dpiAwareness2? x2t2;          //10.1607
                public uint? x2t3;          //10.1803

                public w32.dpi.t.dpiAwarenessP? x3p;          //8.1

                public static w32.dpi.t.dpiAwarenessContext? x4a;          //.net 3
            }
            public aware a = new();



            public class dpi
            {
                public double? d1w;          //10.1607
                public double? d2s;          //10.1607
                public double? d3p;          //10.1803

                public double? d4d;
                public double? d5g;
                public double? d6r;
            }
            public dpi d = new();



            public enum ver
            {
                not,
                vista8,
                win81,
                win10,
            }
            public static ver v;

            static dpi2()          //version
            {
                w32.info.osVersion x2 = new();
                w32.info.RtlGetVersion(x2);
             
                ver f()
                {
                    if (x2.platform != (uint)PlatformID.Win32NT || x2.v1 < 6) return ver.not;

                    if (x2.v1 == 6)
                    {
                        if (x2.v2 < 3) return ver.vista8;
                        if (x2.v2 == 3) return ver.win81;
                    }

                    if (x2.v1 >= 10) return ver.win10;

                    return ver.not;
                }
                v = f();
            }












            public class result
            {
                public w32.dpi.t.dpiAwarenessContext a;
                public (double d1, double? d11, double? d2l, double? d3s, double? d4t) d;
            }
            public result r = new();

            public void init()
            {

                w32.dpi.t.dpiAwarenessContext f()          //aware
                {

                    if (v == ver.not) return w32.dpi.t.dpiAwarenessContext.not;


                    if (v == ver.vista8)
                        if (aware.x4a != null)
                            return (aware.x4a == w32.dpi.t.dpiAwarenessContext.not || aware.x4a == w32.dpi.t.dpiAwarenessContext.notGdiScaled) ? w32.dpi.t.dpiAwarenessContext.not : w32.dpi.t.dpiAwarenessContext.system;
                        else
                            if (d.d4d != 96 || d.d5g != 96)
                            return w32.dpi.t.dpiAwarenessContext.system;
                        else
                            return (d.d6r != 96) ? w32.dpi.t.dpiAwarenessContext.not : w32.dpi.t.dpiAwarenessContext.not;          //unknown


                    if (v == ver.win81) return w32.dpi.t.cAwarePToContext((w32.dpi.t.dpiAwarenessP)a.x3p);


                    if (v == ver.win10)
                    {
                        if (a.x1w3 != null && a.x2t3 != null && aware.x4a != null) return (w32.dpi.t.dpiAwarenessContext)aware.x4a;
                        try
                        {
                            w32.dpi.t.dpiAwarenessContext? x;
                            if (a.x1w != null && (x = w32.dpi.t.cContextToSimple(a.x1w)) != null) return (w32.dpi.t.dpiAwarenessContext)x;
                            if (a.x2t != null && (x = w32.dpi.t.cContextToSimple(a.x2t)) != null) return (w32.dpi.t.dpiAwarenessContext)x;
                        }
                        catch { };
                        if (a.x3p != null) return w32.dpi.t.cAwarePToContext((w32.dpi.t.dpiAwarenessP)a.x3p);
                    }


                    return w32.dpi.t.dpiAwarenessContext.not;
                }
                r.a = f();















                (double, double? , double?, double?, double?) f2()          //dpi
                {
                    var a = r.a;

                    if (v == ver.not) return (96.0, null, null, null, null);

                    if (v == ver.vista8) return (d.d6r ?? 96, null, null, d.d6r, null);

                    if (v == ver.win81) return (d.d6r ?? 96, null, null, d.d6r, null);
                    
                    if (v == ver.win10)
                    {
                        if (a == w32.dpi.t.dpiAwarenessContext.not || a == w32.dpi.t.dpiAwarenessContext.notGdiScaled) return (d.d3p ?? d.d6r ?? 96, null, d.d6r, d.d3p, null);
                        
                        if (a == w32.dpi.t.dpiAwarenessContext.system)
                        {
                            double d3s = d.d3p ?? d.d2s ?? d.d1w ?? d.d4d ?? d.d5g ?? 96;
                            return (d3s, null, d.d6r, d3s, null);
                        }

                        if (a == w32.dpi.t.dpiAwarenessContext.monitor)
                        {
                            double d3s = d.d3p ?? d.d2s ?? d.d4d ?? d.d5g ?? 96;
                            return (d.d1w ?? d3s, null, d.d6r, d3s, d.d1w);
                        }

                        if (a == w32.dpi.t.dpiAwarenessContext.monitor2)
                        {
                            double d3s = d.d3p ?? d.d2s ?? d.d5g ?? 96;
                            double? d4t = d.d1w ?? d.d4d;
                            return (d4t ?? d3s, null, d.d6r, d3s, d4t);
                        }
                    }

                    return (96.0, null, null, null, null);
                }
                r.d = f2();

            }
        }














































































































        private enum d2t
        {
            GetWindowDpiAwarenessContext,
            GetThreadDpiAwarenessContext,
            GetProcessDpiAwareness,

            GetDpiForWindow,
            GetDpiForSystem,
            GetSystemDpiForProcess,

            GetAwarenessFromDpiAwarenessContext,
            GetDpiFromDpiAwarenessContext,
        }
        private static HashSet<d2t> d2f = new();


        public static dpi2 d2(Control x = null)
        {
            dpi2 x2 = new();



            bool f(Action x3, d2t x4)
            {
                if (d2f.Contains(x4)) return false;
                try
                {
                    x3();
                }
                catch (System.TypeLoadException)
                {
                    d2f.Add(x4);
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }



            void f2()          //aware
            {
                dpi2.aware a = x2.a;
                //if (x != null)
                {
                    f(() => a.x1w = w32.dpi.f.getSet.aware.GetWindowDpiAwarenessContext(x?.Handle ?? IntPtr.Zero), d2t.GetWindowDpiAwarenessContext);          //10.1607
                    f(() => a.x1w2 = w32.dpi.f.t.GetAwarenessFromDpiAwarenessContext((w32.dpi.t.dpiAwarenessContext)a.x1w), d2t.GetAwarenessFromDpiAwarenessContext);          //10.1607
                    f(() => a.x1w3 = w32.dpi.f.t.GetDpiFromDpiAwarenessContext((w32.dpi.t.dpiAwarenessContext)a.x1w), d2t.GetDpiFromDpiAwarenessContext);          //10.1803
                }

                f(() => a.x2t = w32.dpi.f.getSet.aware.GetThreadDpiAwarenessContext(), d2t.GetThreadDpiAwarenessContext);          //10.1607
                f(() => a.x2t2 = w32.dpi.f.t.GetAwarenessFromDpiAwarenessContext((w32.dpi.t.dpiAwarenessContext)a.x2t), d2t.GetAwarenessFromDpiAwarenessContext);          //10.1607
                f(() => a.x2t3 = w32.dpi.f.t.GetDpiFromDpiAwarenessContext((w32.dpi.t.dpiAwarenessContext)a.x2t), d2t.GetDpiFromDpiAwarenessContext);          //10.1803

                f(() => { w32.dpi.f.getSet.aware.GetProcessDpiAwareness(IntPtr.Zero, out w32.dpi.t.dpiAwarenessP x3); a.x3p = x3; }, d2t.GetProcessDpiAwareness);          //8.1
            }
            f2();


            void f3()
            {
                dpi2.dpi d = x2.d;
                //if (x != null)
                f(() => d.d1w = w32.dpi.f.getSet.dpi.GetDpiForWindow(x?.Handle ?? IntPtr.Zero), d2t.GetDpiForWindow);          //10.1607

                f(() => d.d2s = w32.dpi.f.getSet.dpi.GetDpiForSystem(), d2t.GetDpiForSystem);          //10.1607

                f(() => d.d3p = w32.dpi.f.getSet.dpi.GetSystemDpiForProcess(IntPtr.Zero), d2t.GetSystemDpiForProcess);          //10.1803

                d.d4d = dpi.f.d(x);

                d.d5g = dpi.f.g(x);

                d.d6r = dpi.f.r;
            }
            f3();


            x2.init();

            return x2;
        }
    }
}