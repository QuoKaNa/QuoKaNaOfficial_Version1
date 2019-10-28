namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDplayor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "DisplayOrder", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "DisplayOrder");
        }
    }
}
