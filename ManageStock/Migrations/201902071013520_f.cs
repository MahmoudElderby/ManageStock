namespace ManageStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Price", c => c.Double(nullable: false));
        }
    }
}
