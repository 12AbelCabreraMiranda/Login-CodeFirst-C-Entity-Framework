namespace Login1CodeFirst.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Login1CodeFirst.Models.LoginContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoginContext context)
        {
            context.Roles.AddOrUpdate(
                p => p.RolName,
                new Rol { RolName = "Administrador" },
                new Rol { RolName = "Cliente" }
                );

            context.Usuarios.AddOrUpdate(
                u=>u.Nombre,
                new Usuario { Nombre="Abel", Apellido="Cabrera", Direccion="Reu",UserName="acabrera",Password="123",RoldID=1}
                );
        }
    }
}
