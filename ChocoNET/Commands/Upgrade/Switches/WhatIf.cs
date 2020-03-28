using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class WhatIf : UpgradeSwitch
    {
        ///<summary>
        ///     --noop, --whatif, --what-if
        ///     NoOp / WhatIf - Don't actually do anything.
        ///</summary>
        public WhatIf() : base("--", UpgradeCommand.SwitchOptions.WHAT_IF)
        {

        }
    }
}
