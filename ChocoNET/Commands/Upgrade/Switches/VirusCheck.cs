using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class VirusCheck : UpgradeSwitch
    {
        ///<summary>
        ///     --virus, --viruscheck, --virus-check
        ///     Virus Check - check downloaded files for viruses. Overrides the default
        ///       feature 'virusCheck' set to 'True'. Available in 0.9.10+. Licensed
        ///       editions only. See https://chocolatey.org/docs/features-virus-check
        ///</summary>
        public VirusCheck() : base("--", UpgradeCommand.SwitchOptions.VIRUS_CHECK)
        {

        }
    }
}
