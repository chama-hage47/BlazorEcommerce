﻿//IMPLEMENTATION CLASS

//In here we define not only the methods but also the product list itself
//because now we will store the products in the service you can access services from here we dont have to make calls in other components its just better architecture

using BlazorEcommerce.Shared;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
	{
		private readonly HttpClient _http;

		public ProductService(HttpClient http)
		{ _http = http; }
		public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
			var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
			return result;
        }

        //public int Service { get; private set; }

       /* public async Task GetProducts()
		{
			var result = 
			  await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
			if (result != null && result.Data != null)
				Products = result.Data;
		}*/

	 public async Task<ServiceResponse<List<Product>>> GetProducts()
		{
			//throw new NotImplementedException();
			var result =
			  await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
			if (result != null && result.Data != null)
				Products = result.Data;
			return result;
		}
	}
}