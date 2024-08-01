using System.Threading.Tasks;
using Library_1.Localization;
using Library_1.Permissions;
using Library_1.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace Library_1.Blazor.Menus;

public class Library_1MenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<Library_1Resource>();
        
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                Library_1Menus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 1
            )
        );

        //Administration
        var administration = context.Menu.GetAdministration();
context.Menu.Items.Remove(administration);
        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        //administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        //administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        context.Menu.AddItem(
    new ApplicationMenuItem(
        "BooksStore",
        l["Menu:Library_1"],
        icon: "fa fa-book"
    ).AddItem(
        new ApplicationMenuItem(
            "BooksStore.Books",
            l["Menu:Books"],
            url: "/books"
        ).RequirePermissions(Library_1Permissions.Books.Default)
    ).AddItem(
        new ApplicationMenuItem(
            "BooksStore.Readers",
            l["Menu:Readers"],
            url: "/readers"
        )
    ).RequirePermissions(Library_1Permissions.Books.Default)
  );

        return Task.CompletedTask;
    }
}
