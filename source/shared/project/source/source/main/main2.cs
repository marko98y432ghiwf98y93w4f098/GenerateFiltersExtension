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
        

        
        private readonly Package main;          //init   main
        //private IServiceProvider packageIServiceProvider => this.package;




        public static main2 x { get; private set; }          //init   main2
        public static void Initialize(Package main) => x = new(main);











        
        
        private main2(Package main)          //init          //add command handlers (callbacks) for menu.button, commands must exist in the command table file
        {
            if (main == null) throw new ArgumentNullException("package");          //init   main
            this.main = main;




            OleMenuCommandService x = (OleMenuCommandService)((IServiceProvider)main).GetService(typeof(IMenuCommandService));
            if (x == null) return;


            x.AddCommand(new OleMenuCommand(this.buttonClick, null, this.buttonBeforeQueryStatus, new CommandID(VisualStudioCppExtensions.main.gui.groupGuid, VisualStudioCppExtensions.main.gui.buttonId)));
            x.AddCommand(new OleMenuCommand(this.button2Click, null, this.buttonBeforeQueryStatus, new CommandID(VisualStudioCppExtensions.main.gui.groupGuid, VisualStudioCppExtensions.main.gui.button2Id)));


            u.forms.S.s2.d.xInit(768.0);
        }






















        
        void buttonBeforeQueryStatus(object sender, EventArgs e)          //callback
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            OleMenuCommand x = (OleMenuCommand)sender;
            if (x == null) return;

            bool b;
            try
            {
                b = projectUtility.pActive().xIsCpp();
            }
            catch (Exception)
            {
                b = false;
            }
            x.Visible = b;
            x.Enabled = b;
        }














        
        
        private void ErrorMessageBox(string m)          //other          //error box
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


