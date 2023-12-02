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


namespace extension
{
    internal sealed partial class main2
    {
        private static main2 x;          //static
        public static main2 instance(Package main) => x ??= new(main);





        private readonly Package x2;          //data



















        private main2(Package x2)          //init          //add command handlers (callbacks) for menu.button, commands must exist in the command table file
        {
            if ((this.x2 = x2) == null) throw new ArgumentNullException("package");          //init   main




            OleMenuCommandService x3 = (OleMenuCommandService)((IServiceProvider)x2).GetService(typeof(IMenuCommandService));
            if (x3 == null) return;

            x3.AddCommand(new OleMenuCommand(this.buttonClick, null, this.buttonBeforeQueryStatus, new CommandID(extension.main.gui.groupGuid, extension.main.gui.buttonId)));
            x3.AddCommand(new OleMenuCommand(this.button2Click, null, this.buttonBeforeQueryStatus, new CommandID(extension.main.gui.groupGuid, extension.main.gui.button2Id)));




            //u.forms.scale.s.data.init(1080);
        }






















        
        void buttonBeforeQueryStatus(object sender, EventArgs e)          //callback
        {
            //ThreadHelper.ThrowIfNotOnUIThread();          2012
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
            VsShellUtilities.ShowMessageBox(x2,
                                            m,
                                            string.Empty,
                                            OLEMSGICON.OLEMSGICON_CRITICAL,
                                            OLEMSGBUTTON.OLEMSGBUTTON_OK,
                                            OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }
    }
}


