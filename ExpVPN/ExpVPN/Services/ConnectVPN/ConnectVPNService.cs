using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpVPN.Domian;
using Windows.Networking.Vpn;
using Windows.Security.Credentials;

namespace ExpVPN.Services.ConnectVPN
{
    public class ConnectVPNService : IConnectVPNService
    {
        private VpnNativeProfile activeProfile;
        public async Task Connect(VPNConnection conn)
        {
            VpnManagementAgent mgr = new VpnManagementAgent();

            VpnNativeProfile profile = new VpnNativeProfile()
            {
                AlwaysOn = false,
                NativeProtocolType = VpnNativeProtocolType.Pptp,
                ProfileName = conn.ConnectionName,
                RememberCredentials = true,
                RequireVpnClientAppUI = true,
                RoutingPolicyType = VpnRoutingPolicyType.SplitRouting,
                TunnelAuthenticationMethod = VpnAuthenticationMethod.PresharedKey,
                UserAuthenticationMethod = VpnAuthenticationMethod.PresharedKey,
            };

            profile.Servers.Add(conn.ServerName);

            VpnManagementErrorStatus profileStatus = await mgr.AddProfileFromObjectAsync(profile);
            PasswordCredential credentials = new PasswordCredential
            {
                UserName = conn.UserName,
                Password = conn.Password,
            };

            VpnManagementErrorStatus connectStatus = await mgr.ConnectProfileWithPasswordCredentialAsync(profile, credentials);
            activeProfile = profile;
        }

        public async Task Disconnect()
        {
            VpnManagementAgent mgr = new VpnManagementAgent();
            mgr.DisconnectProfileAsync(activeProfile);
        }
    }
}
