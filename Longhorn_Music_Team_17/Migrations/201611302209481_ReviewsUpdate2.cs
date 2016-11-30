namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewsUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Owner_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Reviews", "Owner_Id");
            AddForeignKey("dbo.Reviews", "Owner_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Owner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Reviews", new[] { "Owner_Id" });
            DropColumn("dbo.Reviews", "Owner_Id");
        }
    }
}
