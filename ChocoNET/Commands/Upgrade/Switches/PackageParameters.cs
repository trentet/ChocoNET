using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class PackageParameters : UpgradeSwitch
    {
        ///<summary>
        ///     --params, --parameters, --pkgparameters, --packageparameters, --package-parameters=VALUE
        ///<paramref name="paramDelimiter"/>Chararacter that separates each parameter
        ///<paramref name="parameters"/>PackageParameters - Parameters to pass to the package. Defaults to unspecified.
        /// </summary>
        public PackageParameters(string paramDelimiter, params string[] parameters) : base("--", UpgradeCommand.SwitchOptions.PACKAGE_PARAMETERS_EQUALS_VALUE)
        {
            this.Arguments = parameters.ToList();
            this.ArgumentsDelimiter = paramDelimiter;
        }
    }
}