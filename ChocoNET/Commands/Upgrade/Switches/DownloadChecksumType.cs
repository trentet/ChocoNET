using ChocoNET.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class DownloadChecksumType : UpgradeSwitch
    {
        public enum DownloadChecksumTypes
        {
            [Description("md5")]
            MD5,
            [Description("sha1")]
            SHA1,
            [Description("sha256")]
            SHA256, 
            [Description("sha512")]
            SHA512
        }
        
        ///<summary>
        ///     --checksumtype, --checksum-type, --downloadchecksumtype, --download-checksum-type=VALUE
        ///<paramref name="checksumType"/>Download Checksum Type - a user provided checksum type. Overrides the package checksum type (if it has one). Used in conjunction with Download Checksum. Available values are 'md5', 'sha1', 'sha256' or 'sha512'. Defaults to 'md5'. Available in 0.10.0+.
        ///</summary>
        public DownloadChecksumType(DownloadChecksumTypes checksumType = DownloadChecksumTypes.MD5) : base("--", UpgradeCommand.SwitchOptions.DOWNLOAD_CHECKSUM_TYPE_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { checksumType.GetDescription() };
        }
    }
}
