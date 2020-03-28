using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ProxyUser : UpgradeSwitch
    {
        ///<summary>
        ///     --proxy-user=VALUE
        ///<paramref name="username"/>Proxy User Name - Explicit proxy user (optional). Requires explicity proxy (`--proxy` or config setting). Overrides the default proxy user of '123'. Available for config settings in 0.9.9.9+, this CLI option available in 0.10.4+.
        ///</summary>
        public ProxyUser(string username) : base("--", UpgradeCommand.SwitchOptions.PROXY_USER_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { username };
        }
    }
}
