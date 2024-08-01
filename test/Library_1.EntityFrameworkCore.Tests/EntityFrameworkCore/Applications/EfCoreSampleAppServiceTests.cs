using Library_1.Samples;
using Xunit;

namespace Library_1.EntityFrameworkCore.Applications;

[Collection(Library_1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Library_1EntityFrameworkCoreTestModule>
{

}
