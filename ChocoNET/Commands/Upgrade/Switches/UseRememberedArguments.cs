using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class UseRememberedArguments : UpgradeSwitch
    {
        ///<summary>
        ///     --userememberedargs, --userememberedarguments, --userememberedoptions, --use-remembered-args, --use-remembered-arguments, --use-remembered-options
        ///     Use Remembered Options for Upgrade - use the arguments and options used
        ///       during install for upgrade. Does not override arguments being passed at
        ///       runtime. Overrides the default feature
        ///       'useRememberedArgumentsForUpgrades' set to 'False'. Available in 0.10.4+.
        ///</summary>
        public UseRememberedArguments() : base("--", UpgradeCommand.SwitchOptions.USE_REMEMBERED_ARGUMENTS)
        {

        }
    }
}
