namespace AdoNet7_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldPhone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Suppliers", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Name", c => c.String());
            DropColumn("dbo.Suppliers", "PhoneNumber");
        }
    }
}
