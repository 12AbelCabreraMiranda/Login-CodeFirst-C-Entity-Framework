namespace Login1CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterSesion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sesion", "Profesion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sesion", "Profesion");
        }
    }
}
