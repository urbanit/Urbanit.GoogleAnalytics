using Urbanit.GoogleAnalytics.Models;
using Orchard;

namespace Urbanit.GoogleAnalytics.Services
{
    public interface ISettingsService : IDependency
    {
        SettingsRecord Get();
        bool Set(bool enable, string script);
    }
}