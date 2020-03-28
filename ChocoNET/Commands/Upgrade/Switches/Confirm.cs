using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Confirm : UpgradeSwitch
    {
        ///<summary>
        /// -y, --yes, --confirm
        ///     Confirm all prompts - Chooses affirmative answer instead of prompting.
        ///       Implies --accept-license
        ///</summary>
        public Confirm() : base("--", UpgradeCommand.SwitchOptions.CONFIRM)
        {
            
        }
    }
}
