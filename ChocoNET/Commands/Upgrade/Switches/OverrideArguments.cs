using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class OverrideArguments : UpgradeSwitch
    {
        ///<summary>
        /// -o, --override, --overrideargs, --overridearguments, --override-arguments
        ///     OverrideArguments - Should install arguments be used exclusively without
        ///       appending to current package passed arguments? Defaults to false.
        ///</summary>
        public OverrideArguments() : base("--", UpgradeCommand.SwitchOptions.OVERRIDE_ARGUMENTS)
        {

        }
    }
}
