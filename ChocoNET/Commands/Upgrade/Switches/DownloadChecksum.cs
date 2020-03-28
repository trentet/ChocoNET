using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class DownloadChecksum : UpgradeSwitch
    {
        ///<summary>
        ///--checksum, --downloadchecksum, --download-checksum=VALUE
        ///<paramref name="checksum"/>Download Checksum - a user provided checksum for downloaded resources for the package. Overrides the package checksum (if it has one). Defaults to empty. Available in 0.10.0+.
        ///</summary>
        public DownloadChecksum(string checksum = "") : base("--", UpgradeCommand.SwitchOptions.DOWNLOAD_CHECKSUM_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { checksum };
        }
    }
}
