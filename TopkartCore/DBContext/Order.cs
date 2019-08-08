using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class Order
    {
        [Key]
        public long Id { get; set; }
        public long BuyerId { get; set; }
        public long AddressId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public Buyer Buyer { get; set; }
        public Address Address { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
