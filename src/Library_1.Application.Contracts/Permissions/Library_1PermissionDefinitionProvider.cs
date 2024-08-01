using Library_1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Library_1.Permissions;

public class Library_1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Library_1Permissions.GroupName);

        var booksPermission = myGroup.AddPermission(Library_1Permissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(Library_1Permissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(Library_1Permissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(Library_1Permissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Library_1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Library_1Resource>(name);
    }
}
