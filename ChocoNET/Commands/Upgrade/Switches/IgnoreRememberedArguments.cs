using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class IgnoreRememberedArguments : UpgradeSwitch
    {
        ///<summary>
        ///     --ignorerememberedargs, --ignorerememberedarguments, --ignorerememberedoptions, --ignore-remembered-args, --ignore-remembered-arguments, --ignore-remembered-options
        ///     Ignore Remembered Options for Upgrade - ignore the arguments and options
        ///       used during install for upgrade. Overrides the default feature
        ///       'useRememberedArgumentsForUpgrades' set to 'False'. Available in 0.10.4+.
        ///</summary>
        public IgnoreRememberedArguments() : base("--", UpgradeCommand.SwitchOptions.IGNORE_REMEMBERED_ARGUMENTS)
        {

        }
    }
}
