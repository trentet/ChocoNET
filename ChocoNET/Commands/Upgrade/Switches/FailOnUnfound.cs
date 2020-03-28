using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class FailOnUnfound : UpgradeSwitch
    {
        ///<summary>
        ///     --failonunfound, --fail-on-unfound
        ///     Fail On Unfound Packages - If a package is not found in sources
        ///       specified, fail instead of warn.
        ///</summary>
        public FailOnUnfound() : base("--", UpgradeCommand.SwitchOptions.FAIL_ON_UNFOUND)
        {
            
        }
    }
}
