using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopkartCore.DBContext;

namespace TopkartCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private TopkartDBContext dBContext { get; set; }

        public ProductRepository(TopkartDBContext dbContext)
        {
            this.dBContext = dbContext;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await dBContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(long Id)
        {
            var product = from p in dBContext.Products
                            .Where(p => p.Id == Id)
                            select p;
            return await product.FirstOrDefaultAsync();
        }

        public async Task<Product> AddProduct(Product product)
        {
            dBContext.Products.Add(product);
            await dBContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            dBContext.Products.Update(product);
            await dBContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProduct(long id)
        {
            var product = await GetProductById(id);
            dBContext.Products.Remove(product);
            if (await dBContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
