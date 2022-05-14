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
    internal sealed partial class main2
    {
        

        //init   main
        private readonly Package main;
        //private IServiceProvider packageIServiceProvider => this.package;



        //init   main2
        public static main2 instance { get; private set; }
        public static void Initialize(Package main) => instance = new main2(main);











        //int
        //adds command handlers (callbacks) for menu.button, commands must exist in the command table file
        private main2(Package main)
        {
            //init   main
            if (main == null) throw new ArgumentNullException("package");
            this.main = main;




            OleMenuCommandService x = (OleMenuCommandService)((IServiceProvider)main).GetService(typeof(IMenuCommandService));
            if (x == null) return;


            x.AddCommand(new OleMenuCommand(this.buttonClick, null, this.buttonBeforeQueryStatus, new CommandID(VisualStudioCppExtensions.main.gui.groupGuid, VisualStudioCppExtensions.main.gui.buttonId)));
            x.AddCommand(new OleMenuCommand(this.button2Click, null, this.buttonBeforeQueryStatus, new CommandID(VisualStudioCppExtensions.main.gui.groupGuid, VisualStudioCppExtensions.main.gui.button2Id)));
        }














        //callback
        void buttonBeforeQueryStatus(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            OleMenuCommand x = (OleMenuCommand)sender;
            if (x == null) return;

            bool b;
            try
            {
                b = projectUtility.GetActive().xIsCpp();
            }
            catch (Exception)
            {
                b = false;
            }
            x.Visible = b;
            x.Enabled = b;
        }








        //other
        //error box
        private void ErrorMessageBox(string m)
        {
            VsShellUtilities.ShowMessageBox(main,
                                            m,
                                            string.Empty,
                                            OLEMSGICON.OLEMSGICON_CRITICAL,
                                            OLEMSGBUTTON.OLEMSGBUTTON_OK,
                                            OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }
    }
}


