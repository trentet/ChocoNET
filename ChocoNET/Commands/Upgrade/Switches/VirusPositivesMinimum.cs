using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class VirusPositivesMinimum : UpgradeSwitch
    {
        ///<summary>
        ///     --viruspositivesmin, --virus-positives-minimum=VALUE
        ///<paramref name="minimumVirusScanPositivesBeforeFlagging"/>Virus Check Minimum Scan Result Positives - the minimum number of scan result positives required to flag a package. Used when virusScannerType is VirusTotal. Overrides the default configuration value 'virusCheckMinimumPositives' set to '5'. Available in 0.9.10+. Licensed editions only. See https://chocolatey.org/docs/features-virus-check
        ///</summary>
        public VirusPositivesMinimum(int minimumVirusScanPositivesBeforeFlagging) : base("--", UpgradeCommand.SwitchOptions.VIRUS_POSITIVES_MINIMUM_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { minimumVirusScanPositivesBeforeFlagging.ToString() };
        }
    }
}
