using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Password : UpgradeSwitch
    {
        ///<summary>
        /// -p, --password=VALUE
        ///<paramref name="password"/>Password - the user's password to the source. Defaults to empty.
        ///</summary>
        public Password(string password = "") : base("--", UpgradeCommand.SwitchOptions.PASSWORD_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { password };
        }
    }
}

