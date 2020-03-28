using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class IgnorePackageExitCodes : UpgradeSwitch
    {
        ///<summary>
        ///     --ignorepackagecodes, --ignorepackageexitcodes, --ignore-package-codes, --ignore-package-exit-codes
        ///     IgnorePackageExitCodes - Exit with a 0 for success and 1 for non-succes-
        ///       s, no matter what package scripts provide for exit codes. Overrides the
        ///       default feature 'usePackageExitCodes' set to 'True'. Available in 0.-
        ///       9.10+.
        ///</summary>
        public IgnorePackageExitCodes() : base("--", UpgradeCommand.SwitchOptions.IGNORE_PACKAGE_EXIT_CODES)
        {

        }
    }
}
