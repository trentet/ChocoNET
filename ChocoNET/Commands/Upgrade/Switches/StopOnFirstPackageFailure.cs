using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class StopOnFirstPackageFailure : UpgradeSwitch
    {
        ///<summary>
        ///     --stoponfirstfailure, --stop-on-first-failure, --stop-on-first-package-failure
        ///     Stop On First Package Failure - stop running install, upgrade or
        ///       uninstall on first package failure instead of continuing with others.
        ///       Overrides the default feature 'stopOnFirstPackageFailure' set to 'False-
        ///       '. Available in 0.10.4+.
        ///</summary>
        public StopOnFirstPackageFailure() : base("--", UpgradeCommand.SwitchOptions.STOP_ON_FIRST_PACKAGE_FAILURE)
        {
            
        }
    }
}
