using AutoMapper;
using Library_1.Books;

namespace Library_1;

public class Library_1ApplicationAutoMapperProfile : Profile
{
    public Library_1ApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
