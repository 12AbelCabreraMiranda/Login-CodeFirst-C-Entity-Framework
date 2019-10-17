using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Login1CodeFirst.Models
{
    [Table("Sesion")]
    public class Sesion
    {
        [Key]
        public int SesionId { get; set; }

        public string NombreSesion { get; set; }
        public string Profesion { get; set; }

    }
}