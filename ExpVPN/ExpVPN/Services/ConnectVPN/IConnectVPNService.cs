using ExpVPN.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpVPN.Services.ConnectVPN
{
    public interface IConnectVPNService
    {
        void Connect(VPNConnection conn);
        void Disconnect();
    }
}
