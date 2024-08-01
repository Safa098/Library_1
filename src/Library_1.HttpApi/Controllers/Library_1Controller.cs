using Library_1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Library_1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Library_1Controller : AbpControllerBase
{
    protected Library_1Controller()
    {
        LocalizationResource = typeof(Library_1Resource);
    }
}
