using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopkartCore.DBContext;

namespace TopkartCore.Services
{
    public interface IProductService
    {

        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(long id);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<bool> DeleteProduct(long id);
    }
}
