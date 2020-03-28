using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ExitWhenRebootDetected : UpgradeSwitch
    {
        ///<summary>
        ///     --exitwhenrebootdetected, --exit-when-reboot-detected
        ///     Exit When Reboot Detected - Stop running install, upgrade, or uninstall
        ///       when a reboot request is detected. Requires 'usePackageExitCodes'
        ///       feature to be turned on. Will exit with either 350 or 1604.  Overrides
        ///       the default feature 'exitOnRebootDetected' set to 'False'.  Available in
        ///       0.10.12+.
        ///</summary>
        public ExitWhenRebootDetected() : base("--", UpgradeCommand.SwitchOptions.EXIT_WHEN_REBOOT_DETECTED)
        {
            
        }
    }
}
