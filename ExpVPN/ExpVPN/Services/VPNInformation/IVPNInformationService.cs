using ExpVPN.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpVPN.Services.VPNInformation
{
    public interface IVPNInformationService
    {
        VPNConnection Get();
    }
}
