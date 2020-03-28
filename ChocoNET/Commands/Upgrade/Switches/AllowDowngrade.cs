using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class AllowDowngrade : UpgradeSwitch
    {
        ///<summary>
        ///     --allowdowngrade, --allow-downgrade
        ///     AllowDowngrade - Should an attempt at downgrading be allowed? Defaults
        ///       to false.
        ///</summary>
        public AllowDowngrade() : base("--", UpgradeCommand.SwitchOptions.ALLOW_DOWNGRADE)
        {
            
        }
    }
}
