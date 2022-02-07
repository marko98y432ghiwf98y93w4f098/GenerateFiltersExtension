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





        public static void vcFile(VCFile x)
        {

            //id
            string name = x.Name;          //file.cpp
            string itemName = x.ItemName;          //file.cpp
            string extension = x.Extension;          //.filters, .h, .cpp

            string fullPath = x.FullPath;          //<fullPath>\\file.cpp
            string relativePath = x.RelativePath;          //<relativePath>\\file.cpp
            string unexpandedRelativePath = x.UnexpandedRelativePath;          //<relativePathUnexpanded>\\file.cpp



            string kind = x.Kind;          //[VCFile]
            //strings[0].Add(kind);
            
            string itemType = x.ItemType;          //[null, clInclude, none, clCompile]
            //strings[1].Add(itemType);
            
            string contentType = x.ContentType;          //[Filters, cppHeader, "", cppCode]
            //strings[2].Add(contentType);
            
            string fileType = x.FileType.ToString();          //enum     eFileType[Filters, CppHeader, Document, CppCode]
            //strings[3].Add(fileType);
            
            string subType = x.SubType;          //[""]
            //strings[4].Add(subType);
            
            bool deploymentContent = x.DeploymentContent;          //false





            //children
            object items = x.Items;          //iVcCollection
            object fileConfigurations = x.FileConfigurations;          //iVcCollection

            string customTool = x.CustomTool;          //[""]
            //strings[5].Add(customTool);







            //parent, sibling
            ProjectItem object2 = (ProjectItem)x.Object;          //projectItem
            object parent = x.Parent;          //vcProject, vcFilter
            VCProject project = (VCProject)x.project;          //vcProject
            VCProjectEngine vcProjectEngine = (VCProjectEngine)x.VCProjectEngine;          //vcProjectEngine










            





























            //x.MatchName;



            //x.Move;
            //x.CanMove;
            //x.Remove;

            //x.GetFileConfigurationForProjectConfiguration;



            //x.AddFile;          da li je moguce dodati pod fajl
            //x.CanAddFile;
            //x.RemoveFile;


























            //internal     vcFileShim
            //id
            //string itemFileName = x;
            //string itemFullPath = x;
            //string persistPath = x;



            //bool isBuildable = x;
            //bool isGenerator = x;
            //bool isSharedItem = x;





            //parent,   sibling
            //externalCookie = x;
            //externalCookieId = x;


            //object projectItem = x;
            //object vsObject = x;


            //object parentName = x;
            //object projectInternal = x;
            //object containingSharedProject = x;
            //object toolInternal = x;
            //object projectConfiguration = x;



        }
    }
}