using AutoMapper;
using Library_1.Books;

namespace Library_1.Blazor;

public class Library_1BlazorAutoMapperProfile : Profile
{
    public Library_1BlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}
