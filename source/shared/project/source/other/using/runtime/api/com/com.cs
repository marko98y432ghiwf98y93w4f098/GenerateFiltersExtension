using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;


namespace u.api;

public class com
{
    [ComImport]
    [Guid("00020400-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface iDispatch
    {
        int getTypeInfoCount();

        [return: MarshalAs(UnmanagedType.Interface)]
        ITypeInfo getTypeInfo(int i, int l);

        void getIdOfNames([In] ref Guid g, [In, MarshalAs(UnmanagedType.LPArray)] string[] name, int name2, int l, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] int[] i);
    }

















    public class type : IDisposable
    {
        public (object x, nint x2) x = new();

        public (Dictionary<Guid, HashSet<(nint i, Type t, Guid t2, Assembly a)>> r, (int a, int t) s) r = new();



        public class dispatch
        {
            public (string name, string doc, int h, string h2) d = new();
            public Exception e;
        }
        public dispatch d = new();








        public void Dispose()
        {
            void f(nint x)
            {
                if (x != IntPtr.Zero)
                    Marshal.Release(x);
            }

            f(x.x2);

            r.r.xFor(x => x.Value.xFor(x => f(x.i)));
        }
    }



























    public static type getType(object x)
    {
        if (!Marshal.IsComObject(x)) throw new("!Marshal.IsComObject(x)");
        type t = new();
        t.x.x = x;
        t.x.x2 = Marshal.GetIUnknownForObject(x);






        {
            HashSet<(nint i, Type t, Guid t2, Assembly a)> r = new();

            var a0 = AppDomain.CurrentDomain.GetAssemblies();
            t.r.s.a = a0.Length;

            foreach (var a in a0)
                try
                {
                    var t0 = a.GetTypes().Where(x => x.IsInterface && (x.GUID != Guid.Empty)).ToArray();
                    t.r.s.t += t0.Length;
                    foreach (var t2 in t0)
                        try
                        {
                            var t3 = t2.GUID;

                            if (Marshal.QueryInterface(t.x.x2, ref t3, out nint x3) != 0 || x3 == IntPtr.Zero) continue;
                            r.Add((x3, t2, t3, a));
                        }
                        catch (Exception) { }
                }
                catch (Exception) { }

            t.r.r = r.GroupBy(x => x.t2).ToDictionary(x => x.Key, x => x.ToHashSet());
        }






        try
        {
            var x3 = (iDispatch)x;

            var t2 = x3.getTypeInfo(0, 1033);

            t2.GetDocumentation(-1, out string name, out string doc, out int h, out string h2);

            t.d.d = (name, doc, h, h2);
        }
        catch (Exception e)
        {
            t.d.e = e;
        }





        return t;
    }
}


