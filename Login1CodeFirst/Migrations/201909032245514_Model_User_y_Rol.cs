namespace Login1CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model_User_y_Rol : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RolID = c.Int(nullable: false, identity: true),
                        RolName = c.String(),
                    })
                .PrimaryKey(t => t.RolID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(),
                        RoldID = c.Int(nullable: false),
                        Rol_RolID = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.Rol_RolID)
                .Index(t => t.Rol_RolID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Rol_RolID", "dbo.Roles");
            DropIndex("dbo.Usuarios", new[] { "Rol_RolID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
        }
    }
}
