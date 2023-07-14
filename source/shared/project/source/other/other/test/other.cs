using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.VCProjectEngine;
using Microsoft.Internal.VisualStudio.PlatformUI;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Text;
using System.Linq;
using u.other;




namespace extension
{
    public partial class test
    {


        
        public static HashSet<string>[] strings;          //data collecting
        public static void stringsInit(int i)
        {
            strings = new HashSet<string>[i];
            for (int i0 = 0; i0 < i; i0++)
                strings[i0] = new HashSet<string>();
        }













































        public static void pathSeparator()
        {
            //DirectorySeparatorChar          \
            //AltDirectorySeparatorChar          /
            //PathSeparator          ;
            //VolumeSeparatorChar          :
        }


        public static void pathChars()
        {
            char[] x = Path.GetInvalidPathChars();
            char[] x2 = Path.GetInvalidFileNameChars();
            char[] x3 = Path.GetInvalidPathChars().Union(Path.GetInvalidFileNameChars()).ToArray();
            char[] x4 = Path.GetInvalidPathChars().Intersect(Path.GetInvalidFileNameChars()).ToArray();
        }




        public static void hashSetPath()
        {
            HashSet<path> x = new();
            x.Add(new path("a/b/c"));
            x.Add(new path("a/b/c2"));
            x.Add(new path("a/b/c3"));
            x.Add(new path("a/b/c4"));
            x.Add(new path("a/b/c5"));
            x.Add(new path("a/b/c6"));

            x.Add(new path("A/b/c5"));
            x.Add(new path("a/B/c5"));
            x.Add(new path("a/b/C5"));
            x.Add(new path("A/B/C5"));
        }




        public static void dirs()
        {
            path x = new("<fullPath>");

            string[] s = Directory.GetFiles(x.x);
            string[] s2 = Directory.GetDirectories(x.x);
            string[] s3 = Directory.GetFileSystemEntries(x.x);


            FileAttributes[] a = s.Select(x2 => File.GetAttributes(x2)).ToArray();
            FileAttributes[] a2 = s2.Select(x2 => File.GetAttributes(x2)).ToArray();
            FileAttributes[] a3 = s3.Select(x2 => File.GetAttributes(x2)).ToArray();

            //[reparsePoint] [dir[H|S] | file[S]],     [!indexedContext] shortcut
        }



        public static void path()
        {
            path x1 = new("a/b/c/d/e");
            path x2 = new("a/b/c/d");
            path x3 = new("a/b/c");
            path x4 = new("a/b");
            path x5 = new("a");
            path x6 = new("");

            path x11 = x1 - x1;
            path x12 = x1 - x2;
            path x13 = x1 - x3;
            path x14 = x1 - x4;
            path x15 = x1 - x5;
            path x16 = x1 - x6;

            path x23 = x2 - x3;
            path x24 = x2 - x4;
            path x25 = x2 - x5;
            path x26 = x2 - x6;

            path x34 = x3 - x4;
            path x35 = x3 - x5;
            path x36 = x3 - x6;

            path x44 = x4 - x4;
            path x45 = x4 - x5;
            path x46 = x4 - x6;

            path x55 = x5 - x5;
            path x56 = x5 - x6;

            path x66 = x6 - x6;


            path x21 = x2 - x1;
            path x31 = x3 - x1;
            path x61 = x6 - x1;




            path x7 = new("b");
            path x17 = x1 - x7;
        }












































        public static void classes()
        {
            //IVCBuildCompleteCallback;
            //IVCBuildPropertyStorage;
            //IVCBuildRequest;
            //IVCBuildRequest2;
            //IVCCollection;
            //IVCIdentity;
            //IVCProjectBuildService;
            //IVCProjectEngineEvents;
            //IVCProjectEngineEvents2;
            //IVCProjectTargetChange;
            //IVCProjectTargetDescription;
            //IVCPropertyStorage;
            //IVCRulePropertyStorage;
            //IVCRulePropertyStorage2;
            //IVCTask;









            //VCProjectEngine;
            //VCProjectEngine2;

            //VCProjectEngineObject;
            //VCProjectEngineObjectClass;

            //VCProjectEngineEvents;
            //VCProjectEngineEventsClass;

            


            //VCProject;


            //VCFile;
            //VCFilter;
            //VCProjectItem;

            //VCPropertySheet;


            //VCProjectReference;
            //VCSharedProjectReference;
            //VCReference;
            //VCReferences;








            //VCActiveXReference;
            //VCALinkTool;
            //VCAssemblyReference;
            //VCBscMakeTool;
            //VCCLCompilerTool;
            //VCConfiguration;
            //VCConfiguration2;
            //VCConfiguration3;
            //VCCustomBuildTool;
            //VCDebugSettings;
            //VCFileConfiguration;
            //VCForeignReference;
            //VCFxCopTool;
            //VCFxCopTool2;
            //VCLibrarianTool;
            //VCLinkerTool;
            //VCManagedResourceCompilerTool;
            //VCManifestTool;
            //VCMidlTool;
            //VCNMakeTool;
            //VCPlatform;
            //VCPostBuildEventTool;
            //VCPreBuildEventTool;
            //VCPreLinkEventTool;
            //VCResourceCompilerTool;
            //VCSdkReference;
            //VCToolFile;
            //VCUserMacro;
            //VCWinRTReference;
            //VCXDCMakeTool;
            //VCXMLDataGeneratorTool;













            //SVCProjectEngine;

        }
    }
}