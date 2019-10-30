namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SupportOnlines", "DisplayOrder");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupportOnlines", "DisplayOrder", c => c.Int());
        }
    }
}
