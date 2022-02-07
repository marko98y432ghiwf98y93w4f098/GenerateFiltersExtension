using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Internal.VisualStudio.PlatformUI;
using EnvDTE;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;


namespace VisualStudioCppExtensions
{
    internal sealed partial class extension
    {
        







        //error box
        private void ErrorMessageBox(string m)
        {
            VsShellUtilities.ShowMessageBox(package,
                                            m,
                                            string.Empty,
                                            OLEMSGICON.OLEMSGICON_CRITICAL,
                                            OLEMSGBUTTON.OLEMSGBUTTON_OK,
                                            OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }

















        //init   package
        private readonly Package package;
        //private IServiceProvider packageIServiceProvider { get => this.package; }



        //init   extension
        public static extension Instance { get; private set; }
        public static void Initialize(Package package) => Instance = new extension(package);



















        //adds command handlers for menu.button, commands must exist in the command table file
        private extension(Package package)
        {
            if (package == null) throw new ArgumentNullException("package");
            this.package = package;




            OleMenuCommandService x = (OleMenuCommandService)((IServiceProvider)package).GetService(typeof(IMenuCommandService));
            if (x == null) return;


            x.AddCommand(new OleMenuCommand(this.buttonClick, null, this.buttonBeforeQueryStatus, new CommandID(package2.gui.groupGuid, package2.gui.buttonId)));
            x.AddCommand(new OleMenuCommand(this.button2Click, null, this.buttonBeforeQueryStatus, new CommandID(package2.gui.groupGuid, package2.gui.button2Id)));
        }




    }
}


