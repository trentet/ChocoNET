using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ApplyInstallArgumentsToDependencies : UpgradeSwitch
    {
        ///<summary>
        ///     --argsglobal, --args-global, --installargsglobal, --install-args-global, --applyargstodependencies, --apply-args-to-dependencies, --apply-install-arguments-to-dependencies
        ///     Apply Install Arguments To Dependencies  - Should install arguments be
        ///       applied to dependent packages? Defaults to false.
        ///</summary>
        public ApplyInstallArgumentsToDependencies() : base("--", UpgradeCommand.SwitchOptions.APPLY_INSTALL_ARGUMENTS_TO_DEPENDENCIES)
        {
            
        }
    }
}
