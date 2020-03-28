using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class OnlyUpgradeInstalled : UpgradeSwitch
    {
        ///<summary>
        ///     --skip-if-not-installed, --only-upgrade-installed, --skip-when-not-installed
        ///     Skip Packages Not Installed - if a package is not installed, do not
        ///       install it during the upgrade process. Overrides the default feature
        ///       'skipPackageUpgradesWhenNotInstalled' set to 'False'. Available in 0.1-
        ///       0.12+.
        ///</summary>
        public OnlyUpgradeInstalled() : base("--", UpgradeCommand.SwitchOptions.ONLY_UPGRADE_INSTALLED)
        {

        }
    }
}
