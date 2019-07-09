namespace ManageStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brokers",
                c => new
                    {
                        BrokerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BrokerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        StockId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        Commission = c.Double(nullable: false),
                        Broker_BrokerId = c.Int(),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Brokers", t => t.Broker_BrokerId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.Broker_BrokerId)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Broker_BrokerId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Brokers", t => t.Broker_BrokerId)
                .Index(t => t.Broker_BrokerId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Broker_BrokerId", "dbo.Brokers");
            DropForeignKey("dbo.Orders", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.Orders", "Broker_BrokerId", "dbo.Brokers");
            DropIndex("dbo.People", new[] { "Broker_BrokerId" });
            DropIndex("dbo.Orders", new[] { "Person_PersonId" });
            DropIndex("dbo.Orders", new[] { "Broker_BrokerId" });
            DropTable("dbo.Stocks");
            DropTable("dbo.People");
            DropTable("dbo.Orders");
            DropTable("dbo.Brokers");
        }
    }
}
