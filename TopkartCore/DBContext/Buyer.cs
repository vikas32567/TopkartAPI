using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class Buyer
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public User User { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Wishlist> Wishlist { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Buyer()
        {
            Addresses = new HashSet<Address>();
            Orders = new HashSet<Order>();
        }
    }
}
