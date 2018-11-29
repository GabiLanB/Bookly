namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 255));
            DropColumn("dbo.MembershipTypes", "DuracionInMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DuracionInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
