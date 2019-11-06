namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Status");
        }
    }
}
