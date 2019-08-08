using System;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class Address
    {
        [Key]
        public long Id { get; set; }
        public long BuyerId { get; set; }
        public string AddressAlias { get; set; }
        public string Name { get; set; }
        public string HouseNo { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public Buyer Buyer { get; set; }
    }
}
