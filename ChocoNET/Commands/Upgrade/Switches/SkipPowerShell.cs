using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class SkipPowerShell : UpgradeSwitch
    {
        ///<summary>
        /// -n, --skippowershell, --skip-powershell, --skipscripts, --skip-scripts, --skip-automation-scripts
        ///     Skip Powershell - Do not run chocolateyInstall.ps1. Defaults to false.
        ///</summary>
        public SkipPowerShell() : base("--", UpgradeCommand.SwitchOptions.SKIP_POWERSHELL)
        {

        }
    }
}
