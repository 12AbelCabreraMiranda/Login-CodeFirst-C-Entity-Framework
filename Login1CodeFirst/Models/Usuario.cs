using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Login1CodeFirst.Models
{
    [Table("Usuarios")]//Le asigno un nombre a la tabla manualmente
    public class Usuario
    {
        //MODELOS DE LOS DATOS
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido ")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido ")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido ")]
        [Display(Name ="Nombre de Usuario" )]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido ")]
        [Display(Name ="Contraseña")]
        public string Password { get; set; }

        [Display(Name ="Tipo de Usuario")]
        public int RoldID { get; set; }

        //SE HACE REFERENCIA A LA TABLA DE RELACIÓN
        public virtual Rol Rol { get; set; }

    }
}