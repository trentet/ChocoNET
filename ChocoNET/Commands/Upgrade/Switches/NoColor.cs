using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class NoColor : UpgradeSwitch
    {
        ///<summary>
        ///     --nocolor, --no-color
        ///     No Color - Do not show colorization in logging output. This overrides
        ///       the feature 'logWithoutColor', set to 'False'. Available in 0.10.9+.
        ///</summary>
        public NoColor() : base("--", UpgradeCommand.SwitchOptions.NO_COLOR)
        {

        }
    }
}
