using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class Seller
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public string SellerName { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public User User { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
