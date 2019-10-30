namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDisplay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupportOnlines", "DisplayOrder", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SupportOnlines", "DisplayOrder");
        }
    }
}
