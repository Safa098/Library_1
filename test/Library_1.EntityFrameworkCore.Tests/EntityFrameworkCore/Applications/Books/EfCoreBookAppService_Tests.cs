using Library_1.Books;
using Xunit;

namespace Library_1.EntityFrameworkCore.Applications.Books;

[Collection(Library_1TestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<Library_1EntityFrameworkCoreTestModule>
{

}