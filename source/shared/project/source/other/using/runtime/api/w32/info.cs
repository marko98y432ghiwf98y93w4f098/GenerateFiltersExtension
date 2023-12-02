using System.Runtime.InteropServices;

namespace u.api
{
    public partial class w32
    {
        public class info
        {
            [DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall)] public extern static int RtlGetVersion([In, Out] osVersion x);          //5.0


            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            public class osVersion
            {
                uint size = (uint)Marshal.SizeOf<osVersion>();
                public uint v1;
                public uint v2;
                public uint v3;
                public uint platform;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string nameSp = null;
            }
        }
    }
}
