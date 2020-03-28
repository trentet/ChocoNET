using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Force : UpgradeSwitch
    {
        ///<summary>
        /// -f, --force
        ///     Force - force the behavior. Do not use force during normal operation -
        ///       it subverts some of the smart behavior for commands.
        ///</summary>
        public Force() : base("--", UpgradeCommand.SwitchOptions.FORCE)
        {
            
        }
    }
}
