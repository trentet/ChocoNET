using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class NoProgress : UpgradeSwitch
    {
        ///<summary>
        ///     --no-progress
        ///     Do Not Show Progress - Do not show download progress percentages.
        ///       Available in 0.10.4+.
        ///</summary>
        public NoProgress() : base("--", UpgradeCommand.SwitchOptions.NO_PROGRESS)
        {

        }
    }
}
