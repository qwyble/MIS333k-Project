namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Thomas13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "CVV", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "CVV", c => c.Int(nullable: false));
        }
    }
}
