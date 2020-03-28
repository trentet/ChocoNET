using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class InstallArgumentsSensitive : UpgradeSwitch
    {
        ///<summary>
        ///     --install-arguments-sensitive=VALUE
        ///<paramref name="argDelimiter"/>The character that separates each argument
        ///<paramref name="arguments"/>InstallArgumentsSensitive - Install Arguments to pass to the native installer in the package that are sensitive and you do not want logged. Defaults to unspecified. Available in 0.10.1+. [Licensed editions](https://chocolatey.org/compare) only.
        ///</summary>
        public InstallArgumentsSensitive(string argDelimiter, params string[] arguments) : base("--", UpgradeCommand.SwitchOptions.INSTALL_ARGUMENTS_SENSITIVE_EQUALS_VALUE)
        {
            this.Arguments = arguments.ToList();
            this.ArgumentsDelimiter = argDelimiter;
        }
    }
}
