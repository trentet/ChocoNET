using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class AllowEmptyChecksums : UpgradeSwitch
    {
        ///<summary>
        ///     --allowemptychecksum, --allowemptychecksums, --allow-empty-checksums
        ///     Allow Empty Checksums - Allow packages to have empty/missing checksums
        ///       for downloaded resources from non-secure locations (HTTP, FTP). Use this
        ///       switch is not recommended if using sources that download resources from
        ///       the internet. Overrides the default feature 'allowEmptyChecksums' set to
        ///       'False'. Available in 0.10.0+.
        ///</summary>
        public AllowEmptyChecksums() : base("--", UpgradeCommand.SwitchOptions.ALLOW_EMPTY_CHECKSUMS)
        {
            
        }
    }
}
