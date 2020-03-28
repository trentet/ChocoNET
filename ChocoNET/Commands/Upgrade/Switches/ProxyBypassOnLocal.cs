using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ProxyBypassOnLocal : UpgradeSwitch
    {
        ///<summary>
        ///     --proxy-bypass-on-local
        ///     Proxy Bypass On Local - Bypass proxy for local connections. Requires
        ///       explicity proxy (`--proxy` or config setting). Overrides the default
        ///       proxy bypass on local setting of 'True'. Available in 0.10.4+.
        ///</summary>
        public ProxyBypassOnLocal() : base("--", UpgradeCommand.SwitchOptions.PROXY_BYPASS_ON_LOCAL)
        {

        }
    }
}
