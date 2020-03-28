using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class IgnoreDependencies : UpgradeSwitch
    {
        ///<summary>
        /// -i, --ignoredependencies, --ignore-dependencies
        ///     IgnoreDependencies - Ignore dependencies when upgrading package(s).
        ///       Defaults to false.
        ///</summary>
        public IgnoreDependencies() : base("--", UpgradeCommand.SwitchOptions.IGNORE_DEPENDENCIES)
        {

        }
    }
}
