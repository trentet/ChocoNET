using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class PackageParametersSensitive : UpgradeSwitch
    {
        ///<summary>
        ///     --package-parameters-sensitive=VALUE
        ///<paramref name="paramDelimiter"/>Chararacter that separates each parameter
        ///<paramref name="parameters"/>PackageParametersSensitive - Package Parameters to pass the package that are sensitive and you do not want logged. Defaults to unspecified. Available in 0.10.1+. [Licensed editions](https://chocolatey.org/compare) only.
        ///</summary>

        public PackageParametersSensitive(string paramDelimiter, params string[] parameters) : base("--", UpgradeCommand.SwitchOptions.PACKAGE_PARAMETERS_SENSITIVE_EQUALS_VALUE)
        {
            this.Arguments = parameters.ToList();
            this.ArgumentsDelimiter = paramDelimiter;
        }
    }
}
