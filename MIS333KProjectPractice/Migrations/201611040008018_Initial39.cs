namespace MIS333KProjectPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial39 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingID = c.Int(nullable: false, identity: true),
                        RatingScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RatingID);
            
            CreateTable(
                "dbo.RatingSongs",
                c => new
                    {
                        Rating_RatingID = c.Int(nullable: false),
                        Song_SongID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rating_RatingID, t.Song_SongID })
                .ForeignKey("dbo.Ratings", t => t.Rating_RatingID, cascadeDelete: true)
                .ForeignKey("dbo.Songs", t => t.Song_SongID, cascadeDelete: true)
                .Index(t => t.Rating_RatingID)
                .Index(t => t.Song_SongID);
            
            DropColumn("dbo.Reviews", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Rating", c => c.Int(nullable: false));
            DropForeignKey("dbo.RatingSongs", "Song_SongID", "dbo.Songs");
            DropForeignKey("dbo.RatingSongs", "Rating_RatingID", "dbo.Ratings");
            DropIndex("dbo.RatingSongs", new[] { "Song_SongID" });
            DropIndex("dbo.RatingSongs", new[] { "Rating_RatingID" });
            DropTable("dbo.RatingSongs");
            DropTable("dbo.Ratings");
        }
    }
}
