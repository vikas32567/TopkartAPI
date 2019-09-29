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
        public IProductService productService { get; set; }

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(long id)
        {
            var product = await productService.GetProductById(id);
            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] AddProductPayload addProductPayload)
        {
            var product = addProductPayload.ToProduct();
            var result = await productService.AddProduct(product);
            return Ok(result);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(long id, [FromBody] ProductPayload productPayload)
        {
            var product = productPayload.ToProduct();
            var result = await productService.UpdateProduct(product);
            return Ok(result);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var isProductDeleted = await productService.DeleteProduct(id);
            return Ok(isProductDeleted);
        }
    }
}
