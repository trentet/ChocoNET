using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class AcceptLicense : UpgradeSwitch
    {
        ///<summary>
        ///     --acceptlicense, --accept-license
        ///     AcceptLicense - Accept license dialogs automatically. Reserved for
        ///       future use.
        ///</summary>
        public AcceptLicense() : base("--", UpgradeCommand.SwitchOptions.ACCEPT_LICENSE)
        {
            
        }
    }
}
