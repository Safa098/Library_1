using Library_1.Samples;
using Xunit;

namespace Library_1.EntityFrameworkCore.Domains;

[Collection(Library_1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Library_1EntityFrameworkCoreTestModule>
{

}
