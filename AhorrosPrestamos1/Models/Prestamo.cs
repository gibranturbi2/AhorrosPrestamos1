using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AhorrosPrestamos1.Models
{
    [Table("Prestamo")]
    public class Prestamo
    {
        [Key]
        public int ID_Loan { get; set; }
        public string Name_Client { get; set; }
        public double Amount { get; set; }
        public double Interest { get; set; }
        public double Share { get; set; }
        public double Payment_fee { get; set; }
        public double Total_Amount { get; set; }
    }
}