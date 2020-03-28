using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class FailOnNotInstalled : UpgradeSwitch
    {
        ///<summary>
        ///     --failonnotinstalled, --fail-on-not-installed
        ///     Fail On Non-installed Packages - If a package is not already installed,
        ///       fail instead of installing.
        ///</summary>
        public FailOnNotInstalled() : base("--", UpgradeCommand.SwitchOptions.FAIL_ON_NOT_INSTALLED)
        {
            
        }
    }
}
