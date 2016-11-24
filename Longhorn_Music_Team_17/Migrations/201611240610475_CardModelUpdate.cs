namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardModelUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AppUserCards", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AppUserCards", "Card_CardID", "dbo.Cards");
            DropIndex("dbo.AppUserCards", new[] { "AppUser_Id" });
            DropIndex("dbo.AppUserCards", new[] { "Card_CardID" });
            AddColumn("dbo.Cards", "AppUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Cards", "Owner_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Card_CardID", c => c.Int());
            CreateIndex("dbo.Cards", "AppUser_Id");
            CreateIndex("dbo.Cards", "Owner_Id");
            CreateIndex("dbo.AspNetUsers", "Card_CardID");
            AddForeignKey("dbo.Cards", "AppUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUsers", "Card_CardID", "dbo.Cards", "CardID");
            AddForeignKey("dbo.Cards", "Owner_Id", "dbo.AspNetUsers", "Id");
            DropTable("dbo.AppUserCards");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AppUserCards",
                c => new
                    {
                        AppUser_Id = c.String(nullable: false, maxLength: 128),
                        Card_CardID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AppUser_Id, t.Card_CardID });
            
            DropForeignKey("dbo.Cards", "Owner_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Card_CardID", "dbo.Cards");
            DropForeignKey("dbo.Cards", "AppUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "Card_CardID" });
            DropIndex("dbo.Cards", new[] { "Owner_Id" });
            DropIndex("dbo.Cards", new[] { "AppUser_Id" });
            DropColumn("dbo.AspNetUsers", "Card_CardID");
            DropColumn("dbo.Cards", "Owner_Id");
            DropColumn("dbo.Cards", "AppUser_Id");
            CreateIndex("dbo.AppUserCards", "Card_CardID");
            CreateIndex("dbo.AppUserCards", "AppUser_Id");
            AddForeignKey("dbo.AppUserCards", "Card_CardID", "dbo.Cards", "CardID", cascadeDelete: true);
            AddForeignKey("dbo.AppUserCards", "AppUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
