using System;
using System.ComponentModel.DataAnnotations;
using TopkartCore.DBContext;

namespace TopkartCore.Models
{
    public class AddProductPayload
    {
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

        public Product ToProduct()
        {
            var product = new Product();
            product.SellerId = SellerId;
            product.ProductName = ProductName;
            product.Description = Description;
            product.Price = Price;
            product.StockQuantity = StockQuantity;

            return product;
        }

    }
}
