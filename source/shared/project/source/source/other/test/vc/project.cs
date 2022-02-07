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




namespace VisualStudioCppExtensions
{
    public partial class test
    {

        public delegate void vcx<T>(T x);
        public static void vcCollection<T>(IVCCollection x, vcx<T> v) { foreach (T x2 in x) v(x2); }



        public static void vcProject(VCProject p)
        {

            
            
            //children
            object o7 = p.Files;          //iVcCollection
            object o8 = p.Filters;          //iVcCollection
            object o12 = p.Items;          //iVcCollection,          files and top level filters

            object o27 = p.References;          //iVcCollection,   references?
            object o28 = p.ReferencesConsumableByDesigners;          //vcReferences,   references?
            object o40 = p.VCReferences;          //vcReferences


            //children   notImportant
            object o4 = p.Configurations;          //iVcCollection
            object o1 = p.ActiveConfiguration;          //vcConfiguration          [Debug|Win32]
            object o22 = p.Platforms;          //iVcCollection, vcPlatform
            object o38 = p.ToolFiles;          //iVcCollection,          customBuild rule files


            //vcCollection<VCFile>((IVCCollection)p.Files, vcFile);
            //vcCollection<VCFilter>((IVCCollection)p.Filters, vcFilter);
















            //id
            object o18 = p.Name;          //string,          get,set          [projectName]
            object o11 = p.ItemName;          //string          [projectName]
            object o24 = p.ProjectDirectory;          //string          [<fullPath>]
            object o25 = p.ProjectFile;          //string          [<fullPath>\projectName.vcxproj]
            object o26 = p.ProjectGUID;          //string,          internal          [{68E94CA8-81F4-4C52-9BE3-8C34F323FCF7}]

            object o10 = p.IsDirty;          //bool,     internal          [false]

            

            //id   notImportant
            object o14 = p.Kind;          //string,          enum vsCmElement          [VCProject]
            object o13 = p.keyword;          //string,          help keyword dynamic          [Win32Proj]

            object o5 = p.FileEncoding;          //string          [utf-8]
            object o6 = p.FileFormat;          //enum   fileFormat (ansi, unicode, utf8)          [eUTF8]

            object o34 = p.ShowAllFiles;          //bool,          solutionExplorer show all disk files          [false]
            object o3 = p.Capabilities;          //string          [AllTargetOutputGroups IntegratedConsoleDebugging VisualStudioWellKnownOutputGroups VCProject SDKReferences native desktop ProjectReferences SupportsOnlineEnvironments SourceItemsFromImports ProjectConfigurationsDeclaredAsItems SharedProjectReferences VisualC WinRTReferences VCProjectEngineFactory OutputGroups RunningInVisualStudio Microsoft.VisualStudio.ProjectSystem.RetailRuntime AssemblyReferences PropertyManager COMReferences HostSetActiveProjectConfiguration]
            object o9 = p.GetAllowedReferencesTypes;          //uint,   enum?          [36   32-shared   4-cpp]
            
            object o29 = p.RootNamespace;          //string,          rootNamespace for project to be used for managed resource dll naming          [projectName]




            //platform     notImportant
            object o15 = p.LatestTargetPlatformVersion;          //string          [10.0.22000.0]
            object o35 = p.SupportedPlatformNames;          //string          [ARM;Win32;x64]
            object o36 = p.TargetFrameworkMoniker;          //string          [null]
            object o37 = p.TargetFrameworkVersion;          //enumFrameworkVersion          [eFrameworkVersionUnknown]







            //parent,   sibling
            Project o19 = (Project)p.Object;          //dte project
            VCProject o23 = (VCProject)p.project;          //vcProject          []
            object o21 = p.Parent;          //object,          parent immediate          [null]
            VCProjectEngine o39 = (VCProjectEngine)p.VCProjectEngine;          //vcProjectEngine          []








            //deprecated
            //object o2 = p.AssemblyReferenceSearchPaths;          deprecated
            //object o16 = p.ManagedDBConnection;          deprecated          internal
            //object o17 = p.ManagedDBProvider;          deprecated          internal

            //internal
            object o20 = p.OwnerKey;          //string,          internal          []
            object o30 = p.SccAuxPath;          //string,          internal          []
            object o31 = p.SccLocalPath;          //string,          internal          []
            object o32 = p.SccProjectName;          //string,          internal          []
            object o33 = p.SccProvider;          //string,          internal          []



























            //p.AddFile;
            //p.AddFilter;
            //p.AddToolFile;
            //p.IncludeHeaderFile;

            //p.AddConfiguration;
            //p.AddRuleDefinition;
            //p.AddPlatform;

            //p.AddActiveXReference;
            //p.AddAssemblyReference;
            //p.AddProjectReference;
            //p.AddSdkReference;
            //p.AddWebReference;
            //p.AddWinRTReference;




            //p.CanAddFile;
            //p.CanAddFilter;

            //p.CanAddActiveXReference;
            //p.CanAddAssemblyReference;
            //p.CanAddProjectReference;
            //p.CanAddSdkReference;
            //p.CanAddWinRTReference;




            //p.RemoveFile;
            //p.RemoveFilter;
            //p.RemoveToolFile;

            //p.RemoveReference;

            //p.RemoveConfiguration;
            //p.RemoveRuleDefinition;
            //p.RemovePlatform;







            //p.ContainsFileEndingWith;
            //p.ContainsFileWithItemType;
            //p.GetFilesEndingWith;
            //p.GetFilesWithItemType;
            //p.FindFile;


            //p.Save;
            //p.LoadUserFile;
            //p.SaveUserFile;

            //p.GetVCService;
            //p.MakeManagedDBConnection;




            //p.IsCapabilityPresent;
            //p.MatchName;          //-          checked collection item
            //p.Version;





















        }
    }
}