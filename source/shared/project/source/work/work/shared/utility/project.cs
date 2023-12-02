using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.VCProjectEngine;
using System.Threading;
using extension.shared;

namespace extension
{
    namespace shared
    {




        public class Project
        {
            public VCProject p;
            public EnvDTE.Project p2;

            
            public string name;          //id
            public string dir;
            public string dirFile;
            public string guid;

            public Project(VCProject x)
            {
                p = x;
                p2 = ((EnvDTE.Project)p.Object);

                name = p.Name;
                dir = p.ProjectDirectory;
                dirFile = p.ProjectFile;
                guid = p.ProjectGUID;
            }

            //public bool flagDirty { get => p.IsDirty; }
            public bool flagVcxItems { get => dirFile.EndsWith(".vcxItems", StringComparison.OrdinalIgnoreCase); }
        }






    }
}
