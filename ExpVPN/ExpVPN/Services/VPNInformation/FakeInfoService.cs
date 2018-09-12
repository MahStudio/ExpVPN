using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpVPN.Domian;

namespace ExpVPN.Services.VPNInformation
{
    public class FakeInfoService : IVPNInformationService
    {
        public VPNConnection Get()
        {
            return new VPNConnection()
            {
                Password = "9iguz",
                ServerName = "pp-gr.vpnjantit.com",
                UserName = "vpnjantit.com"
            };
        }
    }
}
