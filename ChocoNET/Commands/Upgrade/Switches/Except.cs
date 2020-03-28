using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Except : UpgradeSwitch
    {
        ///<summary>
        ///     --except=VALUE
        ///<paramref name="value"/>Except - a comma-separated list of package names that should not be upgraded when upgrading 'all'. Defaults to empty. Available in 0.9.10+.
        ///</summary>
        public Except(string packageException = "") : base("--", UpgradeCommand.SwitchOptions.EXCEPT_EQUALS_VALUE)
        {
            if(packageException.Trim().Length > 0)
            {
                this.Arguments = new List<string>() { packageException };
            }
        }

        public Except(params string[] packageExceptions) : base("--", UpgradeCommand.SwitchOptions.EXCEPT_EQUALS_VALUE)
        {
            this.Arguments = packageExceptions.ToList();
        }
    }
}
