using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class Help : UpgradeSwitch
    {
        ///<summary>
        ///-?, --help, -h
        ///     Prints out the help menu.
        ///</summary>
        public Help() : base("--", UpgradeCommand.SwitchOptions.HELP)
        {
            
        }
    }
}
