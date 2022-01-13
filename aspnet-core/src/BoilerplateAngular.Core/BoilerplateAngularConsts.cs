using BoilerplateAngular.Debugging;

namespace BoilerplateAngular
{
    public class BoilerplateAngularConsts
    {
        public const string LocalizationSourceName = "BoilerplateAngular";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6061e97eda88461391770a8b98bff4d6";
    }
}
