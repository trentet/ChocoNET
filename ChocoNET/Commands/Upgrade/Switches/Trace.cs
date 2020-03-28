using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Trace : UpgradeSwitch
    {
        ///<summary>
        ///     --trace
        ///     Trace - Show trace messaging. Very, very verbose trace messaging. Avoid
        ///       except when needing super low-level .NET Framework debugging. Available
        ///       in 0.10.4+.
        ///</summary>
        public Trace() : base("--", UpgradeCommand.SwitchOptions.TRACE)
        {

        }
    }
}
