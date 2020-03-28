using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ForceX86 : UpgradeSwitch
    {
        ///<summary>
        ///     --x86, --forcex86
        ///     ForceX86 - Force x86 (32bit) installation on 64 bit systems. Defaults to
        ///       false.
        ///</summary>
        public ForceX86() : base("--", UpgradeCommand.SwitchOptions.FORCEX86)
        {
            
        }
    }
}
