using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class IgnoreChecksums : UpgradeSwitch
    {
        ///<summary>
        ///     --ignorechecksum, --ignore-checksum, --ignorechecksums, --ignore-checksums
        ///     IgnoreChecksums - Ignore checksums provided by the package. Overrides
        ///       the default feature 'checksumFiles' set to 'True'. Available in 0.9.9.9+.
        ///</summary>
        public IgnoreChecksums() : base("--", UpgradeCommand.SwitchOptions.IGNORE_CHECKSUMS)
        {

        }
    }
}
