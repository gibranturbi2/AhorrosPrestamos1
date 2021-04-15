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
        [Display(Name = "Nombre Cliente")]
        public string Name_Client { get; set; }
        [Display(Name = "Apellido")]
        public string Last_Name { get; set; }
        [Display(Name = "Monto")]
        public double Amount { get; set; }
        [Display(Name = "Interes")]
        public double Interest { get; set; }
        [Display(Name = "Cuota")]
        public double Share { get; set; }
        [Display(Name = "Pago Cuota")]
        public double Payment_fee { get; set; }
        [Display(Name = "Total Prestamo")]
        public double Total_Amount { get; set; }


        public virtual Solicitud solicitud { get; set; }
    }
}