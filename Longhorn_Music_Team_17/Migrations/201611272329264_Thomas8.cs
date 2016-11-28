namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Thomas8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cards", "CVV", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cards", "CVV", c => c.Int(nullable: false));
        }
    }
}
