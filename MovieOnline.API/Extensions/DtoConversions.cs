using MovieOnline.API.Entities;
using MovieOnline.Models.Dtos;

namespace MovieOnline.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products,  IEnumerable<ProductCategory> productCategories)
        {
            return(from product in products join ProductCategory in productCategories on product.CategoryId equals ProductCategory.Id select new ProductDto
            {
                Id= product.Id,
                Name= product.Name,
                Description= product.Description,
                ImgUrl= product.ImgUrl,
                Price= product.Price,
                Qty= product.Qty,
                CategoryId= product.CategoryId, 
                CategoryName= ProductCategory.Name
            }).ToList ();
        }
    }
}
