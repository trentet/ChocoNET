using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class SkipVirusCheck : UpgradeSwitch
    {
        ///<summary>
        ///     --svc, --skipvirus, --skip-virus, --skipviruscheck, --skip-virus-check
        ///     Skip Virus Check - Skip the virus check for downloaded files on this ru-
        ///       n. Overrides the default feature 'virusCheck' set to 'True'. Available
        ///       in 0.9.10+. [Licensed editions](https://chocolatey.org/compare) only. See https://chocolate-
        ///       y.org/docs/features-virus-check
        ///</summary>
        public SkipVirusCheck() : base("--", UpgradeCommand.SwitchOptions.SKIP_VIRUS_CHECK)
        {

        }
    }
}
