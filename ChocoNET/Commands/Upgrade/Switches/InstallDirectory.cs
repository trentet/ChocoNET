using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class InstallDirectory : UpgradeSwitch
    {
        ///<summary>
        ///     --dir, --directory, --installdir, --installdirectory, --install-dir, --install-directory=VALUE
        ///<paramref name="directory"/>Install Directory Override - Override the default installation directory. Chocolatey will automatically determine the type of installer and pass the appropriate arguments to override the install directory. The package must use Chocolatey install helpers and be installing an installer for software. Available in 0.9.10+. [Licensed editions](https://chocolatey.org/compare) only. See https://chocolatey.org/docs/features-install-directory-override
        ///</summary>
        public InstallDirectory(string directory) : base("--", UpgradeCommand.SwitchOptions.INSTALL_DIRECTORY_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { directory };
        }
    }
}
