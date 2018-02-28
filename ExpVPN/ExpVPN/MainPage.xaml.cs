using ExpVPN.Services.VPNInformation;
using ExpVPN.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Autofac;
using ExpVPN.Services.ConnectVPN;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExpVPN
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly IVPNInformationService vpnInfoService;
        private readonly IConnectVPNService vpnConnect;
        public MainPage()
        {
            vpnInfoService = DependencyRegister.Dependencies.Resolve<IVPNInformationService>();
            vpnConnect = DependencyRegister.Dependencies.Resolve<IConnectVPNService>();
            this.InitializeComponent();
            DoStuff();
        }

        private void DoStuff()
        {
            var a = vpnInfoService.Get();
        }
    }
}
