using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ProxyPassword : UpgradeSwitch
    {
        ///<summary>
        ///     --proxy-password=VALUE
        ///     Proxy Password - Explicit proxy password (optional) to be used with
        ///       username. Requires explicity proxy (`--proxy` or config setting) and
        ///       user name.  Overrides the default proxy password (encrypted in settings
        ///       if set). Available for config settings in 0.9.9.9+, this CLI option
        ///       available in 0.10.4+.
        ///</summary>
        public ProxyPassword(string value) : base("--", UpgradeCommand.SwitchOptions.PROXY_PASSWORD_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { value };
        }
    }
}
