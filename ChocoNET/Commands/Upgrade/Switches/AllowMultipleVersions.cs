using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class AllowMultipleVersions : UpgradeSwitch
    {
        ///<summary>
        /// -m, --sxs, --sidebyside, --side-by-side, --allowmultiple, --allow-multiple, --allowmultipleversions, --allow-multiple-versions
        ///     AllowMultipleVersions - Should multiple versions of a package be
        ///       installed? Defaults to false.
        ///</summary>
        public AllowMultipleVersions() : base("--", UpgradeCommand.SwitchOptions.ALLOW_MULTIPLE_VERSIONS)
        {
            
        }
    }
}
