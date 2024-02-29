//Interface
using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;//we will invoke this method whenever the product list will change
        List<Product> Products { get; set; }

        Task GetProducts(string? categoryUrl = null);

        Task<ServiceResponse<Product>> GetProduct(int productId);
		//Task<ServiceResponse<List<Product>>> GetProducts(string? categoryUrl = null);
	}
}
