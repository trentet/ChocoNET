using ChocoNET.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class DownloadChecksumTypeX64 : UpgradeSwitch
    {
        public enum DownloadChecksumTypesX64
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
        ///     --checksumtype64, --checksumtypex64, --checksum-type-x64, --downloadchecksumtypex64, --download-checksum-type-x64=VALUE
        ///<paramref name="checksumTypesX64"/>Download Checksum Type 64bit - a user provided checksum for 64bit downloaded resources for the package. Overrides the package 64-bit checksum (if it has one). Used in conjunction with Download Checksum 64bit. Available values are 'md5', 'sha1', 'sha256' or 'sha512'. Defaults to same as Download Checksum Type. Available in 0.10.0+.
        ///</summary>
        public DownloadChecksumTypeX64(DownloadChecksumTypesX64 checksumTypesX64 = DownloadChecksumTypesX64.MD5) : base("--", UpgradeCommand.SwitchOptions.DOWNLOAD_CHECKSUM_TYPE_X64_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { checksumTypesX64.GetDescription() };
        }
    }
}
