namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "ReviewID", "dbo.Ratings");
            DropIndex("dbo.Reviews", new[] { "ReviewID" });
            DropPrimaryKey("dbo.Reviews");
            AddColumn("dbo.Reviews", "RateNum", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "rating_RatingID", c => c.Int());
            AlterColumn("dbo.Reviews", "ReviewID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Reviews", "ReviewID");
            CreateIndex("dbo.Reviews", "rating_RatingID");
            AddForeignKey("dbo.Reviews", "rating_RatingID", "dbo.Ratings", "RatingID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "rating_RatingID", "dbo.Ratings");
            DropIndex("dbo.Reviews", new[] { "rating_RatingID" });
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Reviews", "ReviewID", c => c.Int(nullable: false));
            DropColumn("dbo.Reviews", "rating_RatingID");
            DropColumn("dbo.Reviews", "RateNum");
            AddPrimaryKey("dbo.Reviews", "ReviewID");
            CreateIndex("dbo.Reviews", "ReviewID");
            AddForeignKey("dbo.Reviews", "ReviewID", "dbo.Ratings", "RatingID");
        }
    }
}
