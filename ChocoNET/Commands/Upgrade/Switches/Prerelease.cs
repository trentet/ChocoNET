using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Prerelease : UpgradeSwitch
    {
        ///<summary>
        ///     --pre, --prerelease
        ///     Prerelease - Include Prereleases? Defaults to false.
        ///</summary>
        public Prerelease() : base("--", UpgradeCommand.SwitchOptions.PRERELEASE)
        {

        }
    }
}
