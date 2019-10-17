using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Login1CodeFirst.Models
{
    public class LoginContext: DbContext
    {
        public LoginContext() : base("Login1CodeF") { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Sesion> Sesion { get; set; }
    }
}