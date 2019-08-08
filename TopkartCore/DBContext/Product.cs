using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        public long SellerId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public Seller Seller { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public Product()
        {
            Wishlists = new HashSet<Wishlist>();
            Carts = new HashSet<Cart>();
            OrderItems = new HashSet<OrderItem>();
        }

    }
}
