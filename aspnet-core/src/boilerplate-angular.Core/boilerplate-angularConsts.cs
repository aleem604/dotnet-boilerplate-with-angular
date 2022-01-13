using boilerplate-angular.Debugging;

namespace boilerplate-angular
{
    public class boilerplate-angularConsts
    {
        public const string LocalizationSourceName = "boilerplate-angular";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c8fcd1dcfa804dbeb23d88dfe3d33272";
    }
}
