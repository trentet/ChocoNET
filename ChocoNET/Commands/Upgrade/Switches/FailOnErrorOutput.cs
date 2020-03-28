using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class FailOnErrorOutput : UpgradeSwitch
    {
        ///<summary>
        ///     --failstderr, --failonstderr, --fail-on-stderr, --fail-on-standard-error, --fail-on-error-output
        ///     FailOnStandardError - Fail on standard error output (stderr), typically
        ///       received when running external commands during install providers. This
        ///       overrides the feature failOnStandardError.
        ///</summary>
        public FailOnErrorOutput() : base("--", UpgradeCommand.SwitchOptions.FAIL_ON_ERROR_OUTPUT)
        {
            
        }
    }
}
