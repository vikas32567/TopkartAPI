using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TopkartCore.DBContext;

namespace TopkartCore.Models
{
    public class ProductPayload
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public long SellerId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Please check that the product name is within limits.")]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Please enter a relevant description.")]
        public string Description { get; set; }

        [Required]
        [Range(5, long.MaxValue, ErrorMessage = "Please enter a proper price.")]
        public int Price { get; set; }

        [Required]
        [Range(0, long.MaxValue, ErrorMessage = "Please enter an appropriate stock value.")]
        public int StockQuantity { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public ProductPayload()
        {

        }

        public Product ToProduct()
        {
            var product = new Product()
            {
                Id = this.Id,
                SellerId = this.SellerId,
                ProductName = this.ProductName,
                Description = this.Description,
                Price = this.Price,
                StockQuantity = this.StockQuantity,
                Modified = this.Modified
            };

            if (this.Created != null)
                product.Created = (DateTime)this.Created;

            return product;
        }
    }
}
