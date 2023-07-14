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




namespace extension
{
    public partial class test
    {
        public static void vcFilter(VCFilter x)
        {



            //id
            string name = x.Name;          //string          source          [change]
            string itemName = x.ItemName;          //string          source          [change]
            string canonicalName = x.CanonicalName;          //string          source\path          [change]
            string uniqueIdentifier = x.UniqueIdentifier;          //string          {44320350-60d6-4c45-b982-939b9678d4b7}          [change]



            //id   notImportant
            string kind = x.Kind;          //string          VCFilter

            string webReference = x.WebReference;          //string          ""          (url for webReference)
            eWebRefUrlBehavior urlBehavior = x.UrlBehavior;          //enum eWebRefUrlBehavior          eSaticUrl          (for webReference filters, is it hard coded in generated cs proxy code)
            
            string filter = x.Filter;          //string          ""          (file extension filter, use?)
            bool parseFiles = x.ParseFiles;          //bool          true          (intellisense allow)
            bool sourceControlFiles = x.SourceControlFiles;          //bool          true          (sourceControl allow)
            
            




            //children
            //x.Files          //iVcCollection
            //x.Filters          //iVcCollection
            //x.Items          //iVcCollection





            //parent, sibling
            ProjectItem projectItem = (ProjectItem)x.Object;          //projectItem?
            object parent = x.Parent;          //vcProject, vcFilter?
            VCProject project = (VCProject)x.project;          //vcProject
            VCProjectEngine vcProjectEngine = (VCProjectEngine)x.VCProjectEngine;          //vcProjectEngine

























            //id
            //x.MatchName;

            //x.Move;
            //x.CanMove;
            //x.Remove;


            //children
            //x.AddFile;
            //x.AddFilter;
            //x.AddWebReference;

            //x.CanAddFile;
            //x.CanAddFilter;

            //x.RemoveFile;
            //x.RemoveFilter;



        }
    }
}