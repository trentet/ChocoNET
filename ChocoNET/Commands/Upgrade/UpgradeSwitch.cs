using ChocoNET.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace ChocoNET.Commands.Upgrade
{
    class UpgradeSwitch : CLITools.Models.CommandSwitch
    {
        private UpgradeCommand.SwitchOptions switchOption;
        public UpgradeSwitch(
            string prefix,
            UpgradeCommand.SwitchOptions switchOption) : base(prefix, switchOption.GetDescription()) 
        { 
            this.switchOption = switchOption; 
        }

        public UpgradeSwitch(
            string prefix,
            UpgradeCommand.SwitchOptions switchOption,
            IEnumerable<string> arguments) : base(prefix, switchOption.GetDescription(), arguments.ToArray())
        {
            this.switchOption = switchOption;
        }

        public UpgradeSwitch(
            string prefix,
            UpgradeCommand.SwitchOptions switchOption,
            params string[] arguments) : base(prefix, switchOption.GetDescription(), arguments.ToArray())
        {
            this.switchOption = switchOption;
        }

        internal UpgradeCommand.SwitchOptions SwitchOption { get => switchOption; }
    }
}
