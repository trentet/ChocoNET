using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class MaximumDownloadBitsPerSecond : UpgradeSwitch
    {
        ///<summary>
        ///     --bps, --maxdownloadrate, --max-download-rate, --maxdownloadbitspersecond, --max-download-bits-per-second, --maximumdownloadbitspersecond, --maximum-download-bits-per-second=VALUE
        ///<paramref name="maxBitsPerSecond"/>Maximum Download Rate Bits Per Second - The maximum download rate in bits per second. '0' or empty means no maximum. A number means that will be the maximum download rate in bps. Defaults to config setting of '0'. Available in [licensed editions](https://chocolatey.org/compare) v1.10+ only. See https://chocolatey.org/docs/features-package-throttle
        ///</summary>
        public MaximumDownloadBitsPerSecond(int maxBitsPerSecond = 0) : base("--", UpgradeCommand.SwitchOptions.MAXIMUM_DOWNLOAD_BITS_PER_SECOND_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { maxBitsPerSecond.ToString() };
        }
    }
}
