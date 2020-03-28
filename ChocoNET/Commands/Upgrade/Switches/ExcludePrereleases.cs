using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ExcludePrereleases : UpgradeSwitch
    {
        ///<summary>
        ///     --exclude-pre, --exclude-prerelease, --exclude-prereleases
        ///     Exclude Prerelease - Should prerelease be ignored for upgrades? Will be ignored if you pass `--pre`. Available in 0.10.4+.
        ///</summary>
        public ExcludePrereleases() : base("--", UpgradeCommand.SwitchOptions.EXCLUDE_PRERELEASES)
        {
            
        }
    }
}
