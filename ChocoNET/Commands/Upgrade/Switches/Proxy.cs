using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Proxy : UpgradeSwitch
    {
        ///<summary>
        ///     --proxy=VALUE
        ///<paramref name="proxyLocation"/>Proxy Location - Explicit proxy location. Overrides the default proxy location of ''. Available for config settings in 0.9.9.9+, this CLI option available in 0.10.4+.
        ///</summary>
        public Proxy(string proxyLocation) : base("--", UpgradeCommand.SwitchOptions.PROXY_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { proxyLocation };
        }
    }
}
