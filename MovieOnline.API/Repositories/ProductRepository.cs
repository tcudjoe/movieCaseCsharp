using Microsoft.EntityFrameworkCore;
using MovieOnline.API.Data;
using MovieOnline.API.Entities;
using MovieOnline.API.Repositories.Contracts;

namespace MovieOnline.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MovieOnlineDbContext movieOnlineDbContext;
        public ProductRepository(MovieOnlineDbContext movieOnlineDbContext)
        {
            this.movieOnlineDbContext = movieOnlineDbContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.movieOnlineDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.movieOnlineDbContext.Products.ToListAsync();

            return products;
        }
    }
}
