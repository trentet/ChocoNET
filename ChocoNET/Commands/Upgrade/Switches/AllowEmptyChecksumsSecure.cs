using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class AllowEmptyChecksumsSecure : UpgradeSwitch
    {
        ///<summary>
        ///     --allowemptychecksumsecure, --allowemptychecksumssecure, --allow-empty-checksums-secure
        ///     Allow Empty Checksums Secure - Allow packages to have empty checksums
        ///       for downloaded resources from secure locations (HTTPS). Overrides the
        ///       default feature 'allowEmptyChecksumsSecure' set to 'True'. Available in
        ///       0.10.0+.
        ///</summary>
        public AllowEmptyChecksumsSecure() : base("--", UpgradeCommand.SwitchOptions.ALLOW_EMPTY_CHECKSUMS_SECURE)
        {
            
        }
    }
}
