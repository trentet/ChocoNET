using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class UseDownloadCache : UpgradeSwitch
    {
        ///<summary>
        ///     --dc, --downloadcache, --download-cache, --use-download-cache
        ///     Use Download Cache - Use private CDN cache if available for a package.
        ///       Overrides the default feature 'downloadCache' set to 'True'. Available
        ///       in 0.9.10+. [Licensed editions](https://chocolatey.org/compare) only. See https://chocolate-
        ///       y.org/docs/features-private-cdn
        ///</summary>
        public UseDownloadCache() : base("--", UpgradeCommand.SwitchOptions.USE_DOWNLOAD_CACHE)
        {

        }
    }
}
