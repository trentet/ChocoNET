using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class InstallIfNotInstalled : UpgradeSwitch
    {
        ///<summary>
        ///     --install-if-not-installed
        ///     Install Missing Packages When Not Installed - if a package is not
        ///       installed, install it as part of running upgrade (typically default
        ///       behavior). Overrides the default feature
        ///       'skipPackageUpgradesWhenNotInstalled' set to 'False'. Available in 0.1-
        ///       0.12+.
        ///</summary>
        public InstallIfNotInstalled() : base("--", UpgradeCommand.SwitchOptions.INSTALL_IF_NOT_INSTALLED)
        {

        }
    }
}
