using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RepositoryManager.Localization
{
    public static class RepositoryManagerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RepositoryManagerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RepositoryManagerLocalizationConfigurer).GetAssembly(),
                        "RepositoryManager.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
