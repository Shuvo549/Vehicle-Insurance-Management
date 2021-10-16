namespace Vehicle_Insurance_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerNID", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "CustomerOccupation", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Confirm_Password", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CustomerPhoneNumber", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Customers", "CustomerAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerAddress", c => c.String());
            AlterColumn("dbo.Customers", "CustomerPhoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "CustomerEmail", c => c.String());
            AlterColumn("dbo.Customers", "CustomerName", c => c.String());
            DropColumn("dbo.Customers", "Confirm_Password");
            DropColumn("dbo.Customers", "Password");
            DropColumn("dbo.Customers", "CustomerOccupation");
            DropColumn("dbo.Customers", "CustomerNID");
        }
    }
}
