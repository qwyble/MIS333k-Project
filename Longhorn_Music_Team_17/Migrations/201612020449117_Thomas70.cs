namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Thomas70 : DbMigration
    {
        public override void Up()
        {
            Sql("Update dbo.OrderDetails SET SubTotal = Quantity*UnitPrice");
        }
        
        public override void Down()
        {
        }
    }
}
