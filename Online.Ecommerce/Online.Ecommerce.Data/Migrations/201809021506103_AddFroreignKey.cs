namespace Online.Ecommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFroreignKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SalesOrderSummaries", "CustomerID");
            AddForeignKey("dbo.SalesOrderSummaries", "CustomerID", "dbo.Customers", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesOrderSummaries", "CustomerID", "dbo.Customers");
            DropIndex("dbo.SalesOrderSummaries", new[] { "CustomerID" });
        }
    }
}
