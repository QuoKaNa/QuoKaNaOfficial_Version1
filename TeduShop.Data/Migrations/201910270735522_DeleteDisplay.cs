namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDisplay : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Menus", "DisplayOrder");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "DisplayOrder", c => c.Int());
        }
    }
}
