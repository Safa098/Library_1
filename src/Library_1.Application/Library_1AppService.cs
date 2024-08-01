using Library_1.Localization;
using Volo.Abp.Application.Services;

namespace Library_1;

/* Inherit your application services from this class.
 */
public abstract class Library_1AppService : ApplicationService
{
    protected Library_1AppService()
    {
        LocalizationResource = typeof(Library_1Resource);
    }
}
