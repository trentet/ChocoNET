using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class IgnoreDetectedReboot : UpgradeSwitch
    {
        ///<summary>
        ///     --ignoredetectedreboot, --ignore-detected-reboot
        ///     Ignore Detected Reboot - Ignore any detected reboots if found. Overrides
        ///       the default feature 'exitOnRebootDetected' set to 'False'.  Available in
        ///       0.10.12+.
        ///</summary>
        public IgnoreDetectedReboot() : base("--", UpgradeCommand.SwitchOptions.IGNORE_DETECTED_REBOOT)
        {

        }
    }
}
