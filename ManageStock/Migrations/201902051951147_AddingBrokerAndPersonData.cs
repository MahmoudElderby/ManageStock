namespace ManageStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBrokerAndPersonData : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO BROKERS (Name) VALUES ('Broker1' )");
            //Sql("INSERT INTO PEOPLE (Name,Broker_BrokerId) VALUES ('Client1',4 )");
            //Sql("INSERT INTO PEOPLE (Name,Broker_BrokerId) VALUES ('Client2',4 )");
        }
        
        public override void Down()
        {
        }
    }
}
