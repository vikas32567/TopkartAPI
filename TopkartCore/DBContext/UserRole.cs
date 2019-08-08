using System;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class UserRole
    {
        [Key]
        public long Id { get; set; }
        public long RoleId { get; set; }
        public long UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public Role Role { get; set; }
        public User User { get; set; }
    }
}
