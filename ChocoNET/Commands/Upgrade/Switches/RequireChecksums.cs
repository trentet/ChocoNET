using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class RequireChecksums : UpgradeSwitch
    {
        ///<summary>
        ///     --requirechecksum, --requirechecksums, --require-checksums
        ///     Require Checksums - Requires packages to have checksums for downloaded
        ///       resources (both non-secure and secure). Overrides the default feature
        ///       'allowEmptyChecksums' set to 'False' and 'allowEmptyChecksumsSecure' set
        ///       to 'True'. Available in 0.10.0+.
        ///</summary>
        public RequireChecksums() : base("--", UpgradeCommand.SwitchOptions.REQUIRE_CHECKSUMS)
        {
            
        }
    }
}
