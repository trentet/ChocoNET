using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class User : UpgradeSwitch
    {
        ///<summary>
        /// -u, --user=VALUE
        ///<paramref name="user"/>User - used with authenticated feeds. Defaults to empty.
        ///</summary>
        public User(string user = "") : base("--", UpgradeCommand.SwitchOptions.USER_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { user };
        }
    }
}
