using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AhorrosPrestamos1.Models
{
    [Table("Solicitud")]
    public class Solicitud
    {
        [Key]
        public int RequesterID { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Apellido")]
        public string Last_Name { get; set; }
        [Display(Name = "Nacionalidad")]
        public string Nationality { get; set; }
        [Display(Name = "Identificacion")]
        public string Identification { get; set; }
        [Display(Name = "Estado Civil")]
        public string Material_Status { get; set; }
        [Display(Name = "Telefono Celular")]
        public string Phone_Number { get; set; }
        [Display(Name = "Telefono Casa")]
        public string Home_Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Direccion")]
        public string Address { get; set; }
    }
}