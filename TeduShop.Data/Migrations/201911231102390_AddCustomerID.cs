namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerId", c => c.String(maxLength: 128));
            AlterColumn("dbo.ApplicationUsers", "FullName", c => c.String(maxLength: 256));
            AlterColumn("dbo.ApplicationUsers", "Address", c => c.String(maxLength: 256));
            AlterColumn("dbo.ApplicationUsers", "BirthDay", c => c.DateTime());
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.ApplicationUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.ApplicationUsers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            AlterColumn("dbo.ApplicationUsers", "BirthDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ApplicationUsers", "Address", c => c.String());
            AlterColumn("dbo.ApplicationUsers", "FullName", c => c.String());
            DropColumn("dbo.Orders", "CustomerId");
        }
    }
}
