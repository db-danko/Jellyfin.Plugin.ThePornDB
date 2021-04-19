using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

#if __EMBY__
#else
using MediaBrowser.Model.Providers;
#endif

namespace ThePornDB
{
    public class ExternalIdActor : IExternalId
    {
#if __EMBY__
        public string Name => Plugin.Instance.Name;
#else
        public string ProviderName => Plugin.Instance.Name;
#endif

#if __EMBY__
#else
        public ExternalIdMediaType? Type => ExternalIdMediaType.Person;
#endif

        public string Key => Plugin.Instance.Name;

        public string UrlFormatString => Consts.PerfomerURL;

        public bool Supports(IHasProviderIds item) => item is Person;
    }
}
