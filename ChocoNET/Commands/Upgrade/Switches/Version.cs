using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Version : UpgradeSwitch
    {
        ///<summary>
        ///     --version=VALUE
        ///<paramref name="version"/>Version - A specific version to install. Defaults to unspecified.
        ///</summary>
        public Version(string version = "") : base("--", UpgradeCommand.SwitchOptions.VERSION_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { version };
        }
    }
}
