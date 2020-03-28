using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoNET.Commands.Upgrade.Switches
{
    class CacheLocation : UpgradeSwitch
    {
        ///<summary>
        /// -c, --cache, --cachelocation, --cache-location=VALUE
        ///<paramref name="cacheLocation"/>CacheLocation - Location for download cache, defaults to %TEMP% or value in chocolatey.config file.
        ///</summary>
        public CacheLocation(string cacheLocation = "%TEMP%") : base("--", UpgradeCommand.SwitchOptions.CACHE_LOCATION_EQUALS_VALUE)
        {
            this.Arguments = new List<string>() { cacheLocation };
        }
    }
}
