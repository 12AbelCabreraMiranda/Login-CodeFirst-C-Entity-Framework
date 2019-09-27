namespace Login1CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter_table_usuario : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Password", c => c.String());
        }
    }
}
