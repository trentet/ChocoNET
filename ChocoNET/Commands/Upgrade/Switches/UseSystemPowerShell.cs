using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class UseSystemPowerShell : UpgradeSwitch
    {
        ///<summary>
        ///     --use-system-powershell
        ///     UseSystemPowerShell - Execute PowerShell using an external process
        ///       instead of the built-in PowerShell host. Should only be used when
        ///       internal host is failing. Available in 0.9.10+.
        ///</summary>
        public UseSystemPowerShell() : base("--", UpgradeCommand.SwitchOptions.USE_SYSTEM_POWERSHELL)
        {

        }
    }
}
