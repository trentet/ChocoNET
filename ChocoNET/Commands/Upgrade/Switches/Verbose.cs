using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Verbose : UpgradeSwitch
    {
        ///<summary>
        /// -v, --verbose
        ///     Verbose - Show verbose messaging. Very verbose messaging, avoid using under normal circumstances.
        ///</summary>
        public Verbose() : base("--", UpgradeCommand.SwitchOptions.VERBOSE)
        {

        }
    }
}
