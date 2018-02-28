using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ExpVPN.Services.ConnectVPN;
using ExpVPN.Services.VPNInformation;

namespace ExpVPN.Infrastructure
{
    public static class DependencyRegister
    {
        public static IContainer Dependencies;
        public static void BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<VPNInformationService>().As<IVPNInformationService>();
            builder.RegisterType<ConnectVPNService>().As<IConnectVPNService>();
            Dependencies = builder.Build();
        }
    }
}
