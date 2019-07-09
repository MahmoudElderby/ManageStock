namespace ManageStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Orders", "StockId");
            AddForeignKey("dbo.Orders", "StockId", "dbo.Stocks", "StockId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "StockId", "dbo.Stocks");
            DropIndex("dbo.Orders", new[] { "StockId" });
        }
    }
}
