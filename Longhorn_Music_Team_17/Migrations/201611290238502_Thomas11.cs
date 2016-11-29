namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Thomas11 : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Orders DROP CONSTRAINT DF__Orders__CVV__662B2B3B");
                                                       
            AlterColumn("dbo.Orders", "CVV", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "CVV", c => c.Int(nullable: false));
        }
    }
}
