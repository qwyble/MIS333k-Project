namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "AppUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Orders", new[] { "AppUserId" });
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Genres", "GenreName", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "ReviewID", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "Comment", c => c.String(nullable: false));
            AlterColumn("dbo.Cards", "CardNumber", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "StreetAddress", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "AppUserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Reviews", "ReviewID");
            CreateIndex("dbo.Reviews", "ReviewID");
            CreateIndex("dbo.Orders", "AppUserId");
            AddForeignKey("dbo.Reviews", "ReviewID", "dbo.Ratings", "RatingID");
            AddForeignKey("dbo.Orders", "AppUserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Reviews", "RatingLists");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "RatingLists", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "AppUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reviews", "ReviewID", "dbo.Ratings");
            DropIndex("dbo.Orders", new[] { "AppUserId" });
            DropIndex("dbo.Reviews", new[] { "ReviewID" });
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Orders", "AppUserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.String());
            AlterColumn("dbo.AspNetUsers", "StreetAddress", c => c.String());
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AlterColumn("dbo.Cards", "CardNumber", c => c.String());
            AlterColumn("dbo.Reviews", "Comment", c => c.String());
            AlterColumn("dbo.Reviews", "ReviewID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Genres", "GenreName", c => c.String());
            AddPrimaryKey("dbo.Reviews", "ReviewID");
            CreateIndex("dbo.Orders", "AppUserId");
            AddForeignKey("dbo.Orders", "AppUserId", "dbo.AspNetUsers", "Id");
        }
    }
}
