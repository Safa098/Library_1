using System;
using Library_1.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Library_1.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = Library_1Permissions.Books.Default;
        GetListPolicyName = Library_1Permissions.Books.Default;
        CreatePolicyName = Library_1Permissions.Books.Create;
        UpdatePolicyName = Library_1Permissions.Books.Edit;
        DeletePolicyName = Library_1Permissions.Books.Delete;
    }
}