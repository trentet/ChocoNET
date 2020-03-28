using ChocoNET.Commands.Upgrade;
using System.Collections.Generic;

namespace ChocoNET
{
    class Choco : CLITools.Models.CLIProgram
    {
        public Choco() : base(@"C:\ProgramData\chocolatey", "choco")
        {
            Commands = new List<CLITools.Models.CLICommand>()
            {
                new UpgradeCommand(this)
            };
        }
    }
}
