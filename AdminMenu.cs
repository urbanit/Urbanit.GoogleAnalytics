using Orchard.Localization;
using Orchard.Security;
using Orchard.UI.Navigation;

namespace Urbanit.GoogleAnalytics
{
    public class AdminMenu : INavigationProvider
    {
        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.Add(T(text: "Analytics"), position: "4", itemBuilder: menu => menu
                .Add(T(text: "Google Analytics"), position: "1.0", itemBuilder: item => item.Action(actionName: "Index", controllerName: "Admin", values: new { area = "Urbanit.GoogleAnalytics" }).Permission(StandardPermissions.SiteOwner))
            );
        }
    }
}