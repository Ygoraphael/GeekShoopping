using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(int id);
        Task<ProductModel> CreateProduct(ProductModel product);
        Task<ProductModel> UpdateProduct(ProductModel product);
        Task<bool> DeleteProductById(int id);
    }
}
