using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class InstallArguments : UpgradeSwitch
    {
        ///<summary>
        ///     --ia, --installargs, --installarguments, --install-arguments=VALUE
        ///<paramref name="argDelimiter"/>The character that separates each argument
        ///<paramref name="arguments"/>InstallArguments - Install Arguments to pass to the native installer in the package. Defaults to unspecified.
        ///</summary>
        public InstallArguments(string argDelimiter, params string[] arguments) : base("--", UpgradeCommand.SwitchOptions.INSTALL_ARGUMENTS_EQUALS_VALUE)
        {
            this.Arguments = arguments.ToList();
            this.ArgumentsDelimiter = argDelimiter;
        }
    }
}
