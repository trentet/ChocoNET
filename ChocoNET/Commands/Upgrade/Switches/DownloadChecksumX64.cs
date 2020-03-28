using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class DownloadChecksumX64 : UpgradeSwitch
    {
        ///<summary>
        ///     --checksum64, --checksumx64, --downloadchecksumx64, --download-checksum-x64=VALUE
        ///<paramref name="value"/>Download Checksum 64bit - a user provided checksum for 64bit downloaded resources for the package. Overrides the package 64-bit checksum (if it has one). Defaults to same as Download Checksum. Available in 0.10.0+.
        ///</summary>
        public DownloadChecksumX64(string checksum = "") : base("--", UpgradeCommand.SwitchOptions.DOWNLOAD_CHECKSUM_X64_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { checksum };
        }
    }
}
