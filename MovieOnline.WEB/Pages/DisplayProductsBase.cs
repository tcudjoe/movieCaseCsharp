using Microsoft.AspNetCore.Components;
using MovieOnline.Models.Dtos;

namespace MovieOnline.WEB.Pages
{
    public class DisplayProductsBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
