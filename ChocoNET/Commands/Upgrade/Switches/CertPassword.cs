using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class CertPassword : UpgradeSwitch
    {
        ///<summary>
        ///     --cp, --certpassword=VALUE
        ///<paramref name="certificatePassword"/>Certificate Password - the client certificate's password to the source. Defaults to empty. Available in 0.9.10+.
        ///</summary>
        public CertPassword(string certificatePassword = "") : base("--", UpgradeCommand.SwitchOptions.CERTPASSWORD_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { certificatePassword };
        }
    }
}
