using MovieOnline.Models.Dtos;

namespace MovieOnline.WEB.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
