using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace boilerplate-angular.Localization
{
    public static class boilerplate-angularLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(boilerplate-angularConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(boilerplate-angularLocalizationConfigurer).GetAssembly(),
                        "boilerplate-angular.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
