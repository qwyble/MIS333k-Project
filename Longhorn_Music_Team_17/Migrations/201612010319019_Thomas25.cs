namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Thomas25 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cards", "ExpDate", c => c.String(nullable: false));
            AlterColumn("dbo.Cards", "CVV", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cards", "CVV", c => c.String());
            AlterColumn("dbo.Cards", "ExpDate", c => c.String());
        }
    }
}
