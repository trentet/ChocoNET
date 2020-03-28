using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class LogFile : UpgradeSwitch
    {
        ///<summary>
        ///     --log-file=VALUE
        ///<paramref name="logFilePath"/>Log File to output to in addition to regular loggers. Available in 0.10.8+.
        ///</summary>
        public LogFile(string logFilePath) : base("--", UpgradeCommand.SwitchOptions.LOG_FILE_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { logFilePath };
        }
    }
}
