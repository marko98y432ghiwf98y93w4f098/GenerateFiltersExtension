using Microsoft.VisualStudio.VCProjectEngine;




namespace extension;

public partial class test
{
    public static void vcReference(VCReference x)
    {
        //id
        string nameItem = x.ItemName;          //name          [change]
        string label = x.Label;          //name          [change]
        string name = x.Name;          //name          [change]


        string pathFull = x.FullPath;          //path\name.vcxItems          [change]
        string id = x.Identity;          //path\name.vcxItems          [change]








        //flag
#if !s2015
        uint referenceType = x.VCReferenceType;          //32, *          [change]
#endif
        string kind = x.Kind;          //"vcSharedProjectReference", *          [change]

        bool o4 = x.CopyLocalDependencies;          //false          [change]
        bool o24 = x.UseDependenciesInBuild;          //false          [change]














        //parent, sibling
        object o20 = x.Reference;          //VSLangProj.Reference
        VCReferences o17 = (VCReferences)x.Parent;
        VCReferences o27 = (VCReferences)x.VCReferences;
        VCProject o18 = (VCProject)x.project;          //project   referencing
        VCProjectEngine o26 = (VCProjectEngine)x.VCProjectEngine;














        //methods
        //x.Remove();          ok
        //x.MatchName();











































        //notImplemented
        //var o1 = x.AssemblyName;          //not
        //var o3 = x.CopyLocal;          //not
        //var o5 = x.CopyLocalSatelliteAssemblies;          //not
        //var o25 = x.UseInBuild;          //not


        //var o2 = x.BuildNumber;          //not   default
        //var o6 = x.Culture;          //not   default
        //var o7 = x.Description;          //not   default
        //var o13 = x.majorVersion;          //not   default
        //var o14 = x.MinFrameworkVersion;          //not
        //var o15 = x.minorVersion;          //not   default
        //var o19 = x.PublicKeyToken;          //not   default
        //var o21 = x.RevisionNumber;          //not   default
        //var o22 = x.StrongName;          //not   default
        //var o29 = x.Version;          //not   default



        //var o23 = x.SubType;          //deprecated
    }
}