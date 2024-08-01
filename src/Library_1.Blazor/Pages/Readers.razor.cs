using Library_1.Books;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
namespace Library_1.Blazor.Pages
{
    public partial class Readers: ComponentBase
    {
        private readonly IBookAppService _bookAppService;

        public Readers(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        public List<BookDto> BookList { get; set; }
        public bool IsLoading { get; set; }
        protected override async Task OnInitializedAsync()
        {
            IsLoading = true;
            var response = await _bookAppService.GetListAsync(new PagedAndSortedResultRequestDto { });
            BookList = response.Items.ToList();
            await Task.Delay(3000);
            IsLoading = false;
            StateHasChanged();
        }
    }
}
