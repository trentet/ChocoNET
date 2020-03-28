using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ReducePackageSize : UpgradeSwitch
    {
        ///<summary>
        ///     --reduce, --reduce-package-size, --deflate, --deflate-package-size
        ///     Reducer Installed Package Size (Package Reducer) - Reduce size of the
        ///       nupkg file to very small and remove extracted archives and installers.
        ///       Overrides the default feature 'reduceInstalledPackageSpaceUsage' set to
        ///       'True'. [Licensed editions](https://chocolatey.org/compare) only (version 1.12.0+). See https://chocolate-
        ///       y.org/docs/features-package-reducer
        ///</summary>
        public ReducePackageSize() : base("--", UpgradeCommand.SwitchOptions.REDUCE_PACKAGE_SIZE)
        {

        }
    }
}
