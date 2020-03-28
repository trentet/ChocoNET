using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class ApplyPackageParametersToDependencies : UpgradeSwitch
    {
        ///<summary>
        ///     --paramsglobal, --params-global, --packageparametersglobal, --package-parameters-global, --applyparamstodependencies, --apply-params-to-dependencies, --apply-package-parameters-to-dependencies
        ///     Apply Package Parameters To Dependencies  - Should package parameters be
        ///       applied to dependent packages? Defaults to false.
        ///</summary>
        public ApplyPackageParametersToDependencies() : base("--", UpgradeCommand.SwitchOptions.APPLY_PACKAGE_PARAMETERS_TO_DEPENDENCIES)
        {
            
        }
    }
}
