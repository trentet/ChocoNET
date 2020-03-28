using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class AllowUnofficialBuild : UpgradeSwitch
    {
        ///<summary>
        ///     --allowunofficial, --allow-unofficial, --allowunofficialbuild, --allow-unofficial-build
        ///     AllowUnofficialBuild - When not using the official build you must set
        ///       this flag for choco to continue.
        ///</summary>
        public AllowUnofficialBuild() : base("--", UpgradeCommand.SwitchOptions.ALLOW_UNOFFICIAL_BUILD)
        {
            
        }
    }
}
