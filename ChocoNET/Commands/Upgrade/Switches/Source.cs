using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Source : UpgradeSwitch
    {
        ///<summary>
        /// -s, --source=VALUE
        ///     Source - The source to find the package(s) to install. Special sources
        ///       include: ruby, webpi, cygwin, windowsfeatures, and python. To specify
        ///       more than one source, pass it with a semi-colon separating the values (-
        ///       e.g. "'source1;source2'"). Defaults to default feeds.
        ///</summary>
        public Source(string packageSource) : base("--", UpgradeCommand.SwitchOptions.SOURCE_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { packageSource };
            this.ArgumentsDelimiter = ";";
        }

        public Source(params string[] packageSources) : base("--", UpgradeCommand.SwitchOptions.SOURCE_EQUALS_VALUE)
        {
            this.Arguments = new List<string>();
            this.Arguments.AddRange(packageSources);
            this.ArgumentsDelimiter = ";";
        }
    }
}
