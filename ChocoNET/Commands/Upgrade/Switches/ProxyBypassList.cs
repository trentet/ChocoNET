using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ProxyBypassList : UpgradeSwitch
    {
        ///<summary>
        ///     --proxy-bypass-list=VALUE
        ///<paramref name="regexLocationsToBypass"/>ProxyBypassList - Comma separated list of regex locations to bypass on proxy. Requires explicity proxy (`--proxy` or config setting). Overrides the default proxy bypass list of ''. Available in 0.10.4+.
        ///</summary>
        public ProxyBypassList(List<string> regexLocationsToBypass) : base("--", UpgradeCommand.SwitchOptions.PROXY_BYPASS_LIST_EQUALS_VALUE)
        {
            this.Arguments = regexLocationsToBypass;
            this.ArgumentsDelimiter = ", ";
        }
    }
}
