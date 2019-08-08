using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopkartCore.DBContext;
using TopkartCore.Repositories;

namespace TopkartCore.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository productRepository { get; set; }

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await productRepository.GetProducts();
        }

        public async Task<Product> GetProductById(long id)
        {
            return await productRepository.GetProductById(id);
        }

        public async Task<Product> AddProduct(Product product)
        {
            return await productRepository.AddProduct(product);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            return await productRepository.UpdateProduct(product);
        }

        public async Task<bool> DeleteProduct(long id)
        {
            return await productRepository.DeleteProduct(id);
        }


    }
}
