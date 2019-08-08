using System;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public long UserRoleId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public UserRole UserRole { get; set; }
        public Buyer Buyer { get; set; }
        public Seller Seller { get; set; }

    }
}
