using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ExecutionTimeout : UpgradeSwitch
    {
        ///<summary>
        ///     --timeout, --execution-timeout=VALUE
        ///<paramref name="seconds"/>CommandExecutionTimeout (in seconds) - The time to allow a command to finish before timing out. Overrides the default execution timeout in the configuration of 2700 seconds. '0' for infinite starting in 0.10.4.
        ///</summary>
        public ExecutionTimeout(int seconds = 0) : base("--", UpgradeCommand.SwitchOptions.EXECUTION_TIMEOUT_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { seconds.ToString() };
        }
    }
}
