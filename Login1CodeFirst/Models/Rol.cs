using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Login1CodeFirst.Models
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int RolID { get; set; }
        public string RolName { get; set; }
        
        public virtual IEnumerable<Usuario> Usuarios { get; set; }

        public Rol()
        {
            this.Usuarios = new HashSet<Usuario>();
        }
    }
}