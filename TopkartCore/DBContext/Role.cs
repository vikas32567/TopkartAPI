using System;
using System.ComponentModel.DataAnnotations;

namespace TopkartCore.DBContext
{
    public class Role
    {
        [Key]
        public long Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public UserRole UserRole { get; set; }
    }
}
