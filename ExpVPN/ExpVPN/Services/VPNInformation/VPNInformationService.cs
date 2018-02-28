using ExpVPN.Domian;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpVPN.Infrastructure;

namespace ExpVPN.Services.VPNInformation
{
    public class VPNInformationService : IVPNInformationService
    {
        public VPNConnection Get()
        {
            var html = new HtmlWeb().Load(URLconstants.GermanyPPTPServer);
            var div = html.DocumentNode.SelectSingleNode("//div[@id='u120944']");
            var table = div.SelectNodes("//table//td");
            var conn = new VPNConnection()
            {
                ServerName = table[1].InnerText,
                UserName = table[2].InnerText,
                Password = table[3].InnerText
            };
            return conn;
        }
    }
}
