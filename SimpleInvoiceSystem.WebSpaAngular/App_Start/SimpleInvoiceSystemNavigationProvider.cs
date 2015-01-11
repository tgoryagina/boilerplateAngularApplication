using Abp.Application.Navigation;
using Abp.Localization;

namespace SimpleInvoiceSystem.WebSpaAngular
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class SimpleInvoiceSystemNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "TaskList",
                        new LocalizableString("TaskList", SimpleInvoiceSystemConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-tasks"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "NewTask",
                        new LocalizableString("NewTask", SimpleInvoiceSystemConsts.LocalizationSourceName),
                        url: "#/new",
                        icon: "fa fa-asterisk"
                        )
                );
        }
    }
}
