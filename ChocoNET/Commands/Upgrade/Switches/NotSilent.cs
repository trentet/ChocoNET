using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class NotSilent : UpgradeSwitch
    {
        ///<summary>
        ///     --notsilent, --not-silent
        ///     NotSilent - Do not install this silently. Defaults to false.
        ///</summary>
        public NotSilent() : base("--", UpgradeCommand.SwitchOptions.NOT_SILENT)
        {

        }
    }
}
