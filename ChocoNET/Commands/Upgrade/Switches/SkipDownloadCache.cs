using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class SkipDownloadCache : UpgradeSwitch
    {
        ///<summary>
        ///     --sdc, --skipdownloadcache, --skip-download-cache
        ///     Skip Download Cache - Use the original download even if a private CDN
        ///       cache is available for a package. Overrides the default feature
        ///       'downloadCache' set to 'True'. Available in 0.9.10+. [Licensed editions](https://chocolatey.org/compare)
        ///       only. See https://chocolatey.org/docs/features-private-cdn
        ///</summary>
        public SkipDownloadCache() : base("--", UpgradeCommand.SwitchOptions.SKIP_DOWNLOAD_CACHE)
        {

        }
    }
}
