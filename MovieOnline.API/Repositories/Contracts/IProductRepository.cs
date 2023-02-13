using MovieOnline.API.Entities;

namespace MovieOnline.API.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<IEnumerable<Product>> GetItem(int id);
        Task<ProductCategory> GetCategory(int id);
    }
}
