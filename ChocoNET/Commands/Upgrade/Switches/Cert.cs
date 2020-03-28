using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Cert : UpgradeSwitch
    {
        ///<summary>
        ///     --cert=VALUE
        ///<paramref name="pfxPathName"/>Client certificate - PFX pathname for an x509 authenticated feeds. Defaults to empty. Available in 0.9.10+.
        ///</summary>
        public Cert(string pfxPathName = "") : base("--", UpgradeCommand.SwitchOptions.CERT_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { pfxPathName };
        }
    }
}
