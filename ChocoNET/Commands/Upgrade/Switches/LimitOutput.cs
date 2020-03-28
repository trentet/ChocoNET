using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class LimitOutput : UpgradeSwitch
    {
        ///<summary>
        /// -r, --limitoutput, --limit-output
        ///     LimitOutput - Limit the output to essential information
        ///</summary>
        public LimitOutput() : base("--", UpgradeCommand.SwitchOptions.LIMIT_OUTPUT)
        {

        }
    }
}
