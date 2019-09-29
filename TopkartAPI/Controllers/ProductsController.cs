using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopkartCore.Models;
using TopkartCore.Services;

namespace TopkartAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IProductService ProductService { get; set; }

        public ProductsController(IProductService productService)
        {
            this.ProductService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await ProductService.GetProducts();
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(long id)
        {
            var product = await ProductService.GetProductById(id);
            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] AddProductPayload addProductPayload)
        {
            var product = addProductPayload.ToProduct();
            var result = await ProductService.AddProduct(product);
            return Ok(result);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductPayload productPayload)
        {
            var product = productPayload.ToProduct();
            var result = await ProductService.UpdateProduct(product);
            return Ok(result);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var isProductDeleted = await ProductService.DeleteProduct(id);
            return Ok(isProductDeleted);
        }
    }
}
