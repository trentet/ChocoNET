using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Debug : UpgradeSwitch
    {
        ///<summary>
        /// -d, --debug
        ///     Debug - Show debug messaging.
        ///</summary>
        public Debug() : base("--", UpgradeCommand.SwitchOptions.DEBUG)
        {
            
        }
    }
}
