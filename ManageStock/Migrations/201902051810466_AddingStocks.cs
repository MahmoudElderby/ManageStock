namespace ManageStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingStocks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Vianet', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Agritek', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Akamai', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Baidu', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Blinkx', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Blucora', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Boingo', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Brainybrawn', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Carbonite', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('China Finance', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('ChinaCache', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('ADR', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('ChitrChatr', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Cnova', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Cogent', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Crexendo', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('CrowdGather', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('EarthLink', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Eastern', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('ENDEXX', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Envestnet', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Epazz', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('FlashZero', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Genesis', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('InterNAP', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('MeetMe', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Netease', 0 )");
            Sql("INSERT INTO STOCKS (Name,Price) VALUES ('Qihoo', 0 )");

        }
        
        public override void Down()
        {
        }
    }
}
