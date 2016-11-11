namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _132094 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CardUsers", "Card_CardID", "dbo.Cards");
            DropForeignKey("dbo.CardUsers", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Orders", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Reviews", "UserReview_UserID", "dbo.Users");
            DropForeignKey("dbo.ViewModels", "album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.ViewModels", "artist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.ViewModels", "genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.ViewModels", "song_SongID", "dbo.Songs");
            DropIndex("dbo.Orders", new[] { "User_UserID" });
            DropIndex("dbo.Reviews", new[] { "UserReview_UserID" });
            DropIndex("dbo.ViewModels", new[] { "album_AlbumID" });
            DropIndex("dbo.ViewModels", new[] { "artist_ArtistID" });
            DropIndex("dbo.ViewModels", new[] { "genre_GenreID" });
            DropIndex("dbo.ViewModels", new[] { "song_SongID" });
            DropIndex("dbo.CardUsers", new[] { "Card_CardID" });
            DropIndex("dbo.CardUsers", new[] { "User_UserID" });
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        MiddleInitial = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.CardAppUsers",
                c => new
                    {
                        Card_CardID = c.Int(nullable: false),
                        AppUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Card_CardID, t.AppUser_Id })
                .ForeignKey("dbo.Cards", t => t.Card_CardID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUser_Id, cascadeDelete: true)
                .Index(t => t.Card_CardID)
                .Index(t => t.AppUser_Id);
            
            AddColumn("dbo.Orders", "AppUsers_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "AppUsers_Id");
            AddForeignKey("dbo.Orders", "AppUsers_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Orders", "User_UserID");
            DropColumn("dbo.Reviews", "UserReview_UserID");
            DropTable("dbo.Users");
            DropTable("dbo.ViewModels");
            DropTable("dbo.CardUsers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CardUsers",
                c => new
                    {
                        Card_CardID = c.Int(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Card_CardID, t.User_UserID });
            
            CreateTable(
                "dbo.ViewModels",
                c => new
                    {
                        ViewModelID = c.Int(nullable: false, identity: true),
                        album_AlbumID = c.Int(),
                        artist_ArtistID = c.Int(),
                        genre_GenreID = c.Int(),
                        song_SongID = c.Int(),
                    })
                .PrimaryKey(t => t.ViewModelID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleInitial = c.String(maxLength: 1),
                        LastName = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        StreetAddress = c.String(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        UserReview = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.Reviews", "UserReview_UserID", c => c.Int());
            AddColumn("dbo.Orders", "User_UserID", c => c.Int());
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "AppUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.CardAppUsers", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.CardAppUsers", "Card_CardID", "dbo.Cards");
            DropIndex("dbo.CardAppUsers", new[] { "AppUser_Id" });
            DropIndex("dbo.CardAppUsers", new[] { "Card_CardID" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Orders", new[] { "AppUsers_Id" });
            DropColumn("dbo.Orders", "AppUsers_Id");
            DropTable("dbo.CardAppUsers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            CreateIndex("dbo.CardUsers", "User_UserID");
            CreateIndex("dbo.CardUsers", "Card_CardID");
            CreateIndex("dbo.ViewModels", "song_SongID");
            CreateIndex("dbo.ViewModels", "genre_GenreID");
            CreateIndex("dbo.ViewModels", "artist_ArtistID");
            CreateIndex("dbo.ViewModels", "album_AlbumID");
            CreateIndex("dbo.Reviews", "UserReview_UserID");
            CreateIndex("dbo.Orders", "User_UserID");
            AddForeignKey("dbo.ViewModels", "song_SongID", "dbo.Songs", "SongID");
            AddForeignKey("dbo.ViewModels", "genre_GenreID", "dbo.Genres", "GenreID");
            AddForeignKey("dbo.ViewModels", "artist_ArtistID", "dbo.Artists", "ArtistID");
            AddForeignKey("dbo.ViewModels", "album_AlbumID", "dbo.Albums", "AlbumID");
            AddForeignKey("dbo.Reviews", "UserReview_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.Orders", "User_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.CardUsers", "User_UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.CardUsers", "Card_CardID", "dbo.Cards", "CardID", cascadeDelete: true);
        }
    }
}
