using System;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class Wishlist
    {
        [Key]
        public long Id { get; set; }
        public long BuyerId { get; set; }
        public long ProductId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public Buyer Buyer { get; set; }
        public Product Product { get; set; }
    }
}
