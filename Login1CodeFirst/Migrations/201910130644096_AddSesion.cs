namespace Login1CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSesion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sesion",
                c => new
                    {
                        SesionId = c.Int(nullable: false, identity: true),
                        NombreSesion = c.String(),
                    })
                .PrimaryKey(t => t.SesionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sesion");
        }
    }
}
