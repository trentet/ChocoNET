using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class DeflateNupkgOnly : UpgradeSwitch
    {
        ///<summary>
        ///     --reduce-nupkg-only, --deflate-nupkg-only
        ///     Reduce Only Nupkg File Size - reduce only the size of nupkg file when
        ///       using Package Reducer. Overrides the default feature
        ///       'reduceOnlyNupkgSize' set to 'False'. [Licensed editions](https://chocolatey.org/compare) only (version -
        ///       1.12.0+). See https://chocolatey.org/docs/features-package-reducer
        ///</summary>
        public DeflateNupkgOnly() : base("--", UpgradeCommand.SwitchOptions.DEFLATE_NUPKG_ONLY)
        {
            
        }
    }
}
