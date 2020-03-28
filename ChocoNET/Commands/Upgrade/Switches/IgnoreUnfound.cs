using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class IgnoreUnfound : UpgradeSwitch
    {
        ///<summary>
        ///     --ignore-unfound
        ///     Ignore Unfound Packages - Ignore packages that are not found on the
        ///       sources used (or the defaults). Overrides the default feature
        ///       'ignoreUnfoundPackagesOnUpgradeOutdated' set to 'False'. Available in -
        ///       0.10.9+.
        ///</summary>
        public IgnoreUnfound() : base("--", UpgradeCommand.SwitchOptions.IGNORE_UNFOUND)
        {

        }
    }
}
