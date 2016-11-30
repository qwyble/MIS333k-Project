namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reviews3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Comment", c => c.String(nullable: false));
        }
    }
}
