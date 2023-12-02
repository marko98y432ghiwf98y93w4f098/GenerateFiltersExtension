using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using u.api;

namespace extension
{



    [Guid(gui.packageGuid)]          //entry tagged by using attributes
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [PackageRegistration(UseManagedResourcesOnly = true
#if !s2013
, AllowsBackgroundLoading = true
#endif
        )]
    [ProvideAutoLoad(VSConstants.UICONTEXT.SolutionExistsAndFullyLoaded_string
#if !s2013
        , PackageAutoLoadFlags.BackgroundLoad
#endif
        )]

    [ProvideMenuResource("Menus.ctmenu", 1)]          //always

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]








    public sealed class main
#if !s2013
        : AsyncPackage
#else
        : Package
#endif
    {




        public class gui          //gui
        {
            public const string packageGuid = "99d03761-6200-41ad-b2a1-638ae9e780e5";
            public static readonly Guid groupGuid = new("acd8036f-19ae-43b2-a2d6-11788cb282fe");
            public const int buttonId = 0x0100;
            public const int button2Id = 0x0101;
        }















#if !s2013
        protected override async System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
#else
        protected override void Initialize()
#endif
        {
            try
            {
                //Application.SetHighDpiMode(HighDpiMode.PerMonitor);
                //w32.dpi.f.getSet.aware.SetProcessDpiAwareness(w32.dpi.t.dpiAwarenessP.monitor);

                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
            }
            catch (Exception)
            {
            }

#if !s2013
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
#endif
            main2.instance(this);
        }
    }
}
