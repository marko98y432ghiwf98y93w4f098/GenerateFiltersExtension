using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace u.api
{
    public partial class w32
    {
        public class dpi
        {
            public class f
            {
                public class getSet
                {
                    public class dpi
                    {
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static uint GetDpiForSystem();          //10.1607
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static uint GetDpiForWindow(nint window);          //10.1607
                        [DllImport("shcore.dll", CallingConvention = CallingConvention.StdCall, PreserveSig = false)] public extern static void getDpiForMonitor(nint monitor, w32.dpi.t.other.monitorDpiType f, out uint x, out uint y);          //8.1
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static uint GetSystemDpiForProcess(nint process);          //10.1803
                    }

                    public class aware
                    {
                        [DllImport("shcore.dll", CallingConvention = CallingConvention.StdCall, PreserveSig = false)] public extern static void GetProcessDpiAwareness(nint process, out w32.dpi.t.dpiAwarenessP x);          //8.1
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.dpiAwarenessContext GetThreadDpiAwarenessContext();          //10.1607
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.dpiAwarenessContext GetWindowDpiAwarenessContext(nint window);          //10.1607

                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool SetProcessDPIAware();          //vista
                        [DllImport("shcore.dll", CallingConvention = CallingConvention.StdCall, PreserveSig = false)] public extern static void SetProcessDpiAwareness(w32.dpi.t.dpiAwarenessP x);          //8.1
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool SetProcessDpiAwarenessContext(w32.dpi.t.dpiAwarenessContext x);          //10.1703
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.dpiAwarenessContext SetThreadDpiAwarenessContext(w32.dpi.t.dpiAwarenessContext x);          //10.1607
                    }

                    public class behaviorChange          //(dialog manual)
                    {
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool setDialogDpiChangeBehavior(nint window, w32.dpi.t.behaviorChange.dialogDpiChangeBehaviors x2, w32.dpi.t.behaviorChange.dialogDpiChangeBehaviors x);          //10.1703
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.behaviorChange.dialogDpiChangeBehaviors getDialogDpiChangeBehavior(nint window);          //10.1703
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool setDialogControlDpiChangeBehavior(nint window, w32.dpi.t.behaviorChange.dialogControlDpiChangeBehaviors x2, w32.dpi.t.behaviorChange.dialogControlDpiChangeBehaviors x);          //10.1703
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.behaviorChange.dialogControlDpiChangeBehaviors getDialogControlDpiChangeBehavior(nint window);          //10.1703
                    }

                    public class behaviorHosting          //(child aware different)
                    {
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.behaviorHosting.dpiHostingBehavior SetThreadDpiHostingBehavior(w32.dpi.t.behaviorHosting.dpiHostingBehavior x);          //10.1803
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.behaviorHosting.dpiHostingBehavior getThreadDpiHostingBehavior();          //10.1803
                        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static w32.dpi.t.behaviorHosting.dpiHostingBehavior getWindowDpiHostingBehavior(nint window);          //10.1803
                    }
                }





                public class forDpi
                {
                    public class rect { public int x; public int y; public int x2; public int y2; }

                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool adjustWindowRectExForDpi(rect r, uint style, bool menu, uint style2, uint dpi);          //10.1607
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool systemParametersInfoForDpi(uint work, uint id, nint idV, uint idSave, uint dpi);          //10.1607
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static int getSystemMetricsForDpi(int id, uint dpi);          //10.1607
                }





                public class other
                {
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool EnableNonClientDpiScaling(nint window);          //10.1607          //mCreateNc
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static nint openThemeDataForDpi(nint window, string dNameList, uint dpi);          //10.1703
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static uint setThreadCursorCreationScaling(uint dpi);          //unknown          //enum   none 1,   default 2
                }





                public class gui
                {
                    public class point { public int x; public int y; }
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool logicalToPhysicalPointForPerMonitorDpi(nint window, point p);          //8.1
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool physicalToLogicalPointForPerMonitorDpi(nint window, point p);          //8.1
                }





                public class t
                {
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool AreDpiAwarenessContextsEqual(dpi.t.dpiAwarenessContext x, dpi.t.dpiAwarenessContext x2);          //10.1607
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static bool isValidDpiAwarenessContext(dpi.t.dpiAwarenessContext x);          //10.1607
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static dpi.t.dpiAwareness2 GetAwarenessFromDpiAwarenessContext(dpi.t.dpiAwarenessContext x);          //10.1607
                    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)] public extern static uint GetDpiFromDpiAwarenessContext(dpi.t.dpiAwarenessContext x);          //10.1803
                }
            }





























































































            public class t
            {
                public enum dpiAwarenessContext          //10.1607
                {
                    not = -1,
                    system = -2,
                    monitor = -3,
                    monitor2 = -4,          //10.1703
                    notGdiScaled = -5,
                }

                public enum dpiAwareness2          //10
                {
                    invalid = -1,
                    not = 0,
                    system = 1,
                    monitor = 2,
                }

                public enum dpiAwarenessP          //8.1
                {
                    not = 0,
                    system = 1,
                    monitor = 2
                }

                public static dpiAwarenessContext cAwarePToContext(dpiAwarenessP x) => (dpiAwarenessContext)(-((int)x + 1));          //convert
#if NET
                public static dpiAwarenessContext cHighDpiModeToContext(System.Windows.Forms.HighDpiMode x) => (dpiAwarenessContext)(-((int)x + 1));
#endif

                public static dpiAwarenessContext? cAware2ToContext(dpiAwareness2? x)
                {
                    if (x == null || x == dpiAwareness2.invalid) return null;
                    return (dpiAwarenessContext)(-((int)x + 1));
                }

                public static dpiAwarenessContext? cContextToSimple(w32.dpi.t.dpiAwarenessContext? x)
                {
                    foreach (var x2 in Enum.GetValues(typeof(dpiAwarenessContext)).Cast<dpiAwarenessContext>())
                        if (w32.dpi.f.t.AreDpiAwarenessContextsEqual((dpiAwarenessContext)x, x2)) return x2;
                    return null;
                }









                public class behaviorChange          //(dialog manual)
                {
                    public enum dialogDpiChangeBehaviors          //10.1703
                    {
                        default2 = 0,
                        disable = 1,
                        dResize = 2,
                        dChildren = 4,
                    }
                    public enum dialogControlDpiChangeBehaviors          //10.1703
                    {
                        default2 = 0,
                        dFont = 1,
                        dChildren = 2,
                    }
                }

                public class behaviorHosting          //(child aware different)
                {
                    public enum dpiHostingBehavior          //10.1803
                    {
                        invalid = -1,
                        default2 = 0,
                        mixed = 1,
                    }
                }







                public class other
                {
                    public enum monitorDpiType          //8.1
                    {
                        effective = 0,          //default
                        angular = 1,
                        raw = 2,
                    }
                }








































                public enum event2
                {
                    dpiChangedToWinTop = 0x2e0,          //8.1
                    beforeParentToChild = 0x2e2,          //10.1703
                    afterParentToChuld = 0x2e3,          //10.1703
                    getDpiScaledSize = 0x2e4,          //10.1703
                }
            }
        }
    }
}
