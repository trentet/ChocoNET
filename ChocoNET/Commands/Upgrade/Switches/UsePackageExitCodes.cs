using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class UsePackageExitCodes : UpgradeSwitch
    {
        ///<summary>
        ///     --usepackagecodes, --usepackageexitcodes, --use-package-codes, --use-package-exit-codes
        ///     UsePackageExitCodes - Package scripts can provide exit codes. Use those
        ///       for choco's exit code when non-zero (this value can come from a
        ///       dependency package). Chocolatey defines valid exit codes as 0, 1605,
        ///       1614, 1641, 3010. Overrides the default feature 'usePackageExitCodes'
        ///       set to 'True'. Available in 0.9.10+.
        ///</summary>
        public UsePackageExitCodes() : base("--", UpgradeCommand.SwitchOptions.USE_PACKAGE_EXIT_CODES)
        {

        }
    }
}
