using System;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class OrderItem
    {
        [Key]
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
