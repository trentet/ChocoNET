using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class NoReducePackageSize : UpgradeSwitch
    {
        ///<summary>
        ///     --no-reduce, --no-reduce-package-size, --no-deflate, --no-deflate-package-size
        ///     Do Not Reduce Installed Package Size - Leave the nupkg and files alone
        ///       in the package. Overrides the default feature
        ///       'reduceInstalledPackageSpaceUsage' set to 'True'. [Licensed editions](https://chocolatey.org/compare) only
        ///       (version 1.12.0+). See https://chocolatey.org/docs/features-package-
        ///       reducer
        ///</summary>
        public NoReducePackageSize() : base("--", UpgradeCommand.SwitchOptions.NO_REDUCE_PACKAGE_SIZE)
        {

        }
    }
}
