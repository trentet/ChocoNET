using CLITools.Models;
using ChocoNET.Commands.Upgrade.Switches;
using ChocoNET.Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChocoNET.Commands.Upgrade
{
    class UpgradeCommand : CLICommand
    {
        public enum SwitchOptions
        {
            [Description("help")]
            HELP,
            [Description("debug")]
            DEBUG,
            [Description("verbose")]
            VERBOSE,
            [Description("trace")]
            TRACE,
            [Description("no_color")]
            NO_COLOR,
            [Description("accept_license")]
            ACCEPT_LICENSE,
            [Description("confirm")]
            CONFIRM,
            [Description("force")]
            FORCE,
            [Description("what_if")]
            WHAT_IF,
            [Description("limit_output")]
            LIMIT_OUTPUT,
            [Description("execution_timeout=VALUE")]
            EXECUTION_TIMEOUT_EQUALS_VALUE,
            [Description("cache_location=VALUE")]
            CACHE_LOCATION_EQUALS_VALUE,
            [Description("allow_unofficial_build")]
            ALLOW_UNOFFICIAL_BUILD,
            [Description("fail_on_error_output")]
            FAIL_ON_ERROR_OUTPUT,
            [Description("use_system_powershell")]
            USE_SYSTEM_POWERSHELL,
            [Description("no_progress")]
            NO_PROGRESS,
            [Description("proxy=VALUE")]
            PROXY_EQUALS_VALUE,
            [Description("proxy_user=VALUE")]
            PROXY_USER_EQUALS_VALUE,
            [Description("proxy_password=VALUE")]
            PROXY_PASSWORD_EQUALS_VALUE,
            [Description("proxy_bypass_list=VALUE")]
            PROXY_BYPASS_LIST_EQUALS_VALUE,
            [Description("proxy_bypass_on_local")]
            PROXY_BYPASS_ON_LOCAL,
            [Description("log_file=VALUE")]
            LOG_FILE_EQUALS_VALUE,
            [Description("source=VALUE")]
            SOURCE_EQUALS_VALUE,
            [Description("version=VALUE")]
            VERSION_EQUALS_VALUE,
            [Description("prerelease")]
            PRERELEASE,
            [Description("forcex86")]
            FORCEX86,
            [Description("install_arguments=VALUE")]
            INSTALL_ARGUMENTS_EQUALS_VALUE,
            [Description("override_arguments")]
            OVERRIDE_ARGUMENTS,
            [Description("not_silent")]
            NOT_SILENT,
            [Description("package_parameters=VALUE")]
            PACKAGE_PARAMETERS_EQUALS_VALUE,
            [Description("apply_install_arguments_to_dependencies")]
            APPLY_INSTALL_ARGUMENTS_TO_DEPENDENCIES,
            [Description("apply_package_parameters_to_dependencies")]
            APPLY_PACKAGE_PARAMETERS_TO_DEPENDENCIES,
            [Description("allow_downgrade")]
            ALLOW_DOWNGRADE,
            [Description("allow_multiple_versions")]
            ALLOW_MULTIPLE_VERSIONS,
            [Description("ignore_dependencies")]
            IGNORE_DEPENDENCIES,
            [Description("skip_powershell")]
            SKIP_POWERSHELL,
            [Description("fail_on_unfound")]
            FAIL_ON_UNFOUND,
            [Description("ignore_unfound")]
            IGNORE_UNFOUND,
            [Description("fail_on_not_installed")]
            FAIL_ON_NOT_INSTALLED,
            [Description("user=VALUE")]
            USER_EQUALS_VALUE,
            [Description("password=VALUE")]
            PASSWORD_EQUALS_VALUE,
            [Description("cert=VALUE")]
            CERT_EQUALS_VALUE,
            [Description("certpassword=VALUE")]
            CERTPASSWORD_EQUALS_VALUE,
            [Description("ignore_checksums")]
            IGNORE_CHECKSUMS,
            [Description("allow_empty_checksums")]
            ALLOW_EMPTY_CHECKSUMS,
            [Description("allow_empty_checksums_secure")]
            ALLOW_EMPTY_CHECKSUMS_SECURE,
            [Description("require_checksums")]
            REQUIRE_CHECKSUMS,
            [Description("download_checksum=VALUE")]
            DOWNLOAD_CHECKSUM_EQUALS_VALUE,
            [Description("download_checksum_x64=VALUE")]
            DOWNLOAD_CHECKSUM_X64_EQUALS_VALUE,
            [Description("download_checksum_type=VALUE")]
            DOWNLOAD_CHECKSUM_TYPE_EQUALS_VALUE,
            [Description("download_checksum_type_x64=VALUE")]
            DOWNLOAD_CHECKSUM_TYPE_X64_EQUALS_VALUE,
            [Description("ignore_package_exit_codes")]
            IGNORE_PACKAGE_EXIT_CODES,
            [Description("use_package_exit_codes")]
            USE_PACKAGE_EXIT_CODES,
            [Description("except=VALUE")]
            EXCEPT_EQUALS_VALUE,
            [Description("stop_on_first_package_failure")]
            STOP_ON_FIRST_PACKAGE_FAILURE,
            [Description("only_upgrade_installed")]
            ONLY_UPGRADE_INSTALLED,
            [Description("install_if_not_installed")]
            INSTALL_IF_NOT_INSTALLED,
            [Description("exclude_prereleases")]
            EXCLUDE_PRERELEASES,
            [Description("use_remembered_arguments")]
            USE_REMEMBERED_ARGUMENTS,
            [Description("ignore_remembered_arguments")]
            IGNORE_REMEMBERED_ARGUMENTS,
            [Description("exit_when_reboot_detected")]
            EXIT_WHEN_REBOOT_DETECTED,
            [Description("ignore_detected_reboot")]
            IGNORE_DETECTED_REBOOT,
            [Description("skip_download_cache")]
            SKIP_DOWNLOAD_CACHE,
            [Description("use_download_cache")]
            USE_DOWNLOAD_CACHE,
            [Description("skip_virus_check")]
            SKIP_VIRUS_CHECK,
            [Description("virus_check")]
            VIRUS_CHECK,
            [Description("virus_positives_minimum=VALUE")]
            VIRUS_POSITIVES_MINIMUM_EQUALS_VALUE,
            [Description("install_arguments_sensitive=VALUE")]
            INSTALL_ARGUMENTS_SENSITIVE_EQUALS_VALUE,
            [Description("package_parameters_sensitive=VALUE")]
            PACKAGE_PARAMETERS_SENSITIVE_EQUALS_VALUE,
            [Description("install_directory=VALUE")]
            INSTALL_DIRECTORY_EQUALS_VALUE,
            [Description("maximum_download_bits_per_second=VALUE")]
            MAXIMUM_DOWNLOAD_BITS_PER_SECOND_EQUALS_VALUE,
            [Description("reduce_package_size")]
            REDUCE_PACKAGE_SIZE,
            [Description("no_reduce_package_size")]
            NO_REDUCE_PACKAGE_SIZE,
            [Description("deflate_nupkg_only")]
            DEFLATE_NUPKG_ONLY
        }

        private List<string> packageNames = new List<string>();
        private Dictionary<SwitchOptions, UpgradeSwitch> switches = new Dictionary<SwitchOptions, UpgradeSwitch>();

        public List<string> PackageNames { get => packageNames; set => packageNames = value; }
        public new Dictionary<SwitchOptions, UpgradeSwitch> Switches { get => switches; set => switches = value; }

        /*
         * choco upgrade <pkg|all> [<pkg2> <pkgN>] [<options/switches>]
         */
        public UpgradeCommand(Choco parent) : base(parent, "upgrade")
        {
            
        }

        public UpgradeCommand(
            Choco parent,
            params UpgradeSwitch[] upgradeSwitches
        ) : base(parent, "upgrade")
        {
            foreach(UpgradeSwitch upgradeSwitch in upgradeSwitches)
            {
                this.Switches.Add(upgradeSwitch.SwitchOption, upgradeSwitch);
            }
        }

        //public UpgradeCommand(
        //    Choco parent,
        //    UpgradeSwitch upgradeSwitch
        //) : base(parent, "upgrade")
        //{
        //    this.Switches[SwitchOptions.HELP] = new Help();
        //    this.Switches[SwitchOptions.DEBUG] = new Debug();
        //    this.Switches[SwitchOptions.VERBOSE] = new Verbose();
        //    this.Switches[SwitchOptions.TRACE] = new Trace();
        //    this.Switches[SwitchOptions.NO_COLOR] = new NoColor();
        //    this.Switches[SwitchOptions.ACCEPT_LICENSE] = new AcceptLicense();
        //    this.Switches[SwitchOptions.CONFIRM] = new Confirm();
        //    this.Switches[SwitchOptions.FORCE] = new Force();
        //    this.Switches[SwitchOptions.WHAT_IF] = new WhatIf();
        //    this.Switches[SwitchOptions.LIMIT_OUTPUT] = new LimitOutput();
        //    this.Switches[SwitchOptions.EXECUTION_TIMEOUT_EQUALS_VALUE] = new ExecutionTimeout(0);
        //    this.Switches[SwitchOptions.CACHE_LOCATION_EQUALS_VALUE] = new CacheLocation("%TEMP%");
        //    this.Switches[SwitchOptions.ALLOW_UNOFFICIAL_BUILD] = new AllowUnofficialBuild();
        //    this.Switches[SwitchOptions.FAIL_ON_ERROR_OUTPUT] = new FailOnErrorOutput();
        //    this.Switches[SwitchOptions.USE_SYSTEM_POWERSHELL] = new UseSystemPowerShell();
        //    this.Switches[SwitchOptions.NO_PROGRESS] = new NoProgress();
        //    this.Switches[SwitchOptions.PROXY_EQUALS_VALUE] = new Proxy();
        //    this.Switches[SwitchOptions.PROXY_USER_EQUALS_VALUE] = new ProxyUser();
        //    this.Switches[SwitchOptions.PROXY_PASSWORD_EQUALS_VALUE] = new ProxyPassword();
        //    this.Switches[SwitchOptions.PROXY_BYPASS_LIST_EQUALS_VALUE] = new ProxyBypassList();
        //    this.Switches[SwitchOptions.PROXY_BYPASS_ON_LOCAL] = new ProxyBypassOnLocal();
        //    this.Switches[SwitchOptions.LOG_FILE_EQUALS_VALUE] = new LogFile();
        //    this.Switches[SwitchOptions.SOURCE_EQUALS_VALUE] = new Source(null);
        //    this.Switches[SwitchOptions.VERSION_EQUALS_VALUE] = new Version("");
        //    this.Switches[SwitchOptions.PRERELEASE] = new Prerelease();
        //    this.Switches[SwitchOptions.FORCEX86] = new ForceX86();
        //    this.Switches[SwitchOptions.INSTALL_ARGUMENTS_EQUALS_VALUE] = new InstallArguments();
        //    this.Switches[SwitchOptions.OVERRIDE_ARGUMENTS] = new OverrideArguments();
        //    this.Switches[SwitchOptions.NOT_SILENT] = new NotSilent();
        //    this.Switches[SwitchOptions.PACKAGE_PARAMETERS_EQUALS_VALUE] = new PackageParameters();
        //    this.Switches[SwitchOptions.APPLY_INSTALL_ARGUMENTS_TO_DEPENDENCIES] = new ApplyInstallArgumentsToDependencies();
        //    this.Switches[SwitchOptions.APPLY_PACKAGE_PARAMETERS_TO_DEPENDENCIES] = new ApplyPackageParametersToDependencies();
        //    this.Switches[SwitchOptions.ALLOW_DOWNGRADE] = new AllowDowngrade();
        //    this.Switches[SwitchOptions.ALLOW_MULTIPLE_VERSIONS] = new AllowMultipleVersions();
        //    this.Switches[SwitchOptions.IGNORE_DEPENDENCIES] = new IgnoreDependencies();
        //    this.Switches[SwitchOptions.SKIP_POWERSHELL] = new SkipPowerShell();
        //    this.Switches[SwitchOptions.FAIL_ON_UNFOUND] = new FailOnUnfound();
        //    this.Switches[SwitchOptions.IGNORE_UNFOUND] = new IgnoreUnfound();
        //    this.Switches[SwitchOptions.FAIL_ON_NOT_INSTALLED] = new FailOnNotInstalled();
        //    this.Switches[SwitchOptions.USER_EQUALS_VALUE] = new User("");
        //    this.Switches[SwitchOptions.PASSWORD_EQUALS_VALUE] = new Password("");
        //    this.Switches[SwitchOptions.CERT_EQUALS_VALUE] = new Cert("");
        //    this.Switches[SwitchOptions.CERTPASSWORD_EQUALS_VALUE] = new CertPassword("");
        //    this.Switches[SwitchOptions.IGNORE_CHECKSUMS] = new IgnoreChecksums();
        //    this.Switches[SwitchOptions.ALLOW_EMPTY_CHECKSUMS] = new AllowEmptyChecksums();
        //    this.Switches[SwitchOptions.ALLOW_EMPTY_CHECKSUMS_SECURE] = new AllowEmptyChecksumsSecure();
        //    this.Switches[SwitchOptions.REQUIRE_CHECKSUMS] = new RequireChecksums();
        //    this.Switches[SwitchOptions.DOWNLOAD_CHECKSUM_EQUALS_VALUE] = new DownloadChecksum("");
        //    this.Switches[SwitchOptions.DOWNLOAD_CHECKSUM_X64_EQUALS_VALUE] = new DownloadChecksumX64("");
        //    this.Switches[SwitchOptions.DOWNLOAD_CHECKSUM_TYPE_EQUALS_VALUE] = new DownloadChecksumType(DownloadChecksumType.DownloadChecksumTypes.MD5);
        //    this.Switches[SwitchOptions.DOWNLOAD_CHECKSUM_TYPE_X64_EQUALS_VALUE] = new DownloadChecksumTypeX64(DownloadChecksumTypeX64.DownloadChecksumTypesX64.MD5);
        //    this.Switches[SwitchOptions.IGNORE_PACKAGE_EXIT_CODES] = new IgnorePackageExitCodes();
        //    this.Switches[SwitchOptions.USE_PACKAGE_EXIT_CODES] = new UsePackageExitCodes();
        //    this.Switches[SwitchOptions.EXCEPT_EQUALS_VALUE] = new Except("");
        //    this.Switches[SwitchOptions.STOP_ON_FIRST_PACKAGE_FAILURE] = new StopOnFirstPackageFailure();
        //    this.Switches[SwitchOptions.ONLY_UPGRADE_INSTALLED] = new OnlyUpgradeInstalled();
        //    this.Switches[SwitchOptions.INSTALL_IF_NOT_INSTALLED] = new InstallIfNotInstalled();
        //    this.Switches[SwitchOptions.EXCLUDE_PRERELEASES] = new ExcludePrereleases();
        //    this.Switches[SwitchOptions.USE_REMEMBERED_ARGUMENTS] = new UseRememberedArguments();
        //    this.Switches[SwitchOptions.IGNORE_REMEMBERED_ARGUMENTS] = new IgnoreRememberedArguments();
        //    this.Switches[SwitchOptions.EXIT_WHEN_REBOOT_DETECTED] = new ExitWhenRebootDetected();
        //    this.Switches[SwitchOptions.IGNORE_DETECTED_REBOOT] = new IgnoreDetectedReboot();
        //    this.Switches[SwitchOptions.SKIP_DOWNLOAD_CACHE] = new SkipDownloadCache();
        //    this.Switches[SwitchOptions.USE_DOWNLOAD_CACHE] = new UseDownloadCache();
        //    this.Switches[SwitchOptions.SKIP_VIRUS_CHECK] = new SkipVirusCheck();
        //    this.Switches[SwitchOptions.VIRUS_CHECK] = new VirusCheck();
        //    this.Switches[SwitchOptions.VIRUS_POSITIVES_MINIMUM_EQUALS_VALUE] = new VirusPositivesMinimum(5);
        //    this.Switches[SwitchOptions.INSTALL_ARGUMENTS_SENSITIVE_EQUALS_VALUE] = new InstallArgumentsSensitive();
        //    this.Switches[SwitchOptions.PACKAGE_PARAMETERS_SENSITIVE_EQUALS_VALUE] = new PackageParametersSensitive();
        //    this.Switches[SwitchOptions.INSTALL_DIRECTORY_EQUALS_VALUE] = new InstallDirectory();
        //    this.Switches[SwitchOptions.MAXIMUM_DOWNLOAD_BITS_PER_SECOND_EQUALS_VALUE] = new MaximumDownloadBitsPerSecond(0);
        //    this.Switches[SwitchOptions.REDUCE_PACKAGE_SIZE] = new ReducePackageSize();
        //    this.Switches[SwitchOptions.NO_REDUCE_PACKAGE_SIZE] = new NoReducePackageSize();
        //    this.Switches[SwitchOptions.DEFLATE_NUPKG_ONLY] = new DeflateNupkgOnly();
        //}

        //public UpgradeCommand(Choco parent, UpgradeSwitch upgradeSwitch) : base(parent, "upgrade")
        //{
        //    this.Switches.Add(upgradeSwitch.SwitchOption, upgradeSwitch);
        //}
    }
}
