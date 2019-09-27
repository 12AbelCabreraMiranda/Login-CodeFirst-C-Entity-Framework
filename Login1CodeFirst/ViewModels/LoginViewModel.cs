using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login1CodeFirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [Display(Name ="Nombre de Usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        public string Password { get; set; }

    }
}