using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AhorrosPrestamos1.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int ID_Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}