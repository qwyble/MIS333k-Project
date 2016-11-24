namespace Longhorn_Music_Team_17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Thomas2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Albums", "OrderDetail_OrderDetailID", "dbo.OrderDetails");
            DropForeignKey("dbo.Albums", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.CardAppUsers", "Card_CardID", "dbo.Cards");
            DropForeignKey("dbo.CardAppUsers", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "OrderDetail_OrderDetailID", "dbo.OrderDetails");
            DropForeignKey("dbo.Songs", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Songs", "OrderDetail_OrderDetailID", "dbo.OrderDetails");
            DropIndex("dbo.Albums", new[] { "OrderDetail_OrderDetailID" });
            DropIndex("dbo.Albums", new[] { "Order_OrderID" });
            DropIndex("dbo.Songs", new[] { "Order_OrderID" });
            DropIndex("dbo.Songs", new[] { "OrderDetail_OrderDetailID" });
            DropIndex("dbo.Orders", new[] { "OrderDetail_OrderDetailID" });
            DropIndex("dbo.CardAppUsers", new[] { "Card_CardID" });
            DropIndex("dbo.CardAppUsers", new[] { "AppUser_Id" });
            RenameColumn(table: "dbo.Orders", name: "AppUsers_Id", newName: "AppUserId");
            RenameIndex(table: "dbo.Orders", name: "IX_AppUsers_Id", newName: "IX_AppUserId");
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        CartID = c.String(),
                        AlbumID = c.Int(),
                        SongID = c.Int(),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.Albums", t => t.AlbumID)
                .ForeignKey("dbo.Songs", t => t.SongID)
                .Index(t => t.AlbumID)
                .Index(t => t.SongID);
            
            CreateTable(
                "dbo.RatingAlbums",
                c => new
                    {
                        Rating_RatingID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rating_RatingID, t.Album_AlbumID })
                .ForeignKey("dbo.Ratings", t => t.Rating_RatingID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Rating_RatingID)
                .Index(t => t.Album_AlbumID);
            
            CreateTable(
                "dbo.RatingArtists",
                c => new
                    {
                        Rating_RatingID = c.Int(nullable: false),
                        Artist_ArtistID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rating_RatingID, t.Artist_ArtistID })
                .ForeignKey("dbo.Ratings", t => t.Rating_RatingID, cascadeDelete: true)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID, cascadeDelete: true)
                .Index(t => t.Rating_RatingID)
                .Index(t => t.Artist_ArtistID);
            
            AddColumn("dbo.Albums", "DiscountAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Albums", "DiscountedPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Songs", "DiscountAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Songs", "DiscountedPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderDetails", "OrderID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDetails", "AlbumID", c => c.Int());
            AddColumn("dbo.OrderDetails", "SongID", c => c.Int());
            AddColumn("dbo.OrderDetails", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDetails", "Subtotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderDetails", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "CardID", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CardNumber", c => c.String());
            AddColumn("dbo.Orders", "ExpDate", c => c.String());
            AddColumn("dbo.Orders", "CVV", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Subtotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "Tax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "IsGift", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "GiftEmail", c => c.String());
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.Cards", "AppUserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Cards", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Cards", "CardNumber", c => c.String());
            AddColumn("dbo.Cards", "ExpDate", c => c.String());
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.String());
            CreateIndex("dbo.Cards", "AppUserId");
            CreateIndex("dbo.OrderDetails", "OrderID");
            CreateIndex("dbo.OrderDetails", "AlbumID");
            CreateIndex("dbo.OrderDetails", "SongID");
            AddForeignKey("dbo.OrderDetails", "AlbumID", "dbo.Albums", "AlbumID");
            AddForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders", "OrderID", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "SongID", "dbo.Songs", "SongID");
            AddForeignKey("dbo.Cards", "AppUserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Albums", "OrderDetail_OrderDetailID");
            DropColumn("dbo.Albums", "Order_OrderID");
            DropColumn("dbo.Songs", "Order_OrderID");
            DropColumn("dbo.Songs", "OrderDetail_OrderDetailID");
            DropColumn("dbo.OrderDetails", "PurchasePrice");
            DropColumn("dbo.Orders", "PurchasePrice");
            DropColumn("dbo.Orders", "Discount");
            DropColumn("dbo.Orders", "Status");
            DropColumn("dbo.Orders", "OrderDetail_OrderDetailID");
            DropColumn("dbo.Cards", "CardType");
            DropColumn("dbo.Cards", "CardNum");
            DropTable("dbo.CardAppUsers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CardAppUsers",
                c => new
                    {
                        Card_CardID = c.Int(nullable: false),
                        AppUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Card_CardID, t.AppUser_Id });
            
            AddColumn("dbo.Cards", "CardNum", c => c.Long(nullable: false));
            AddColumn("dbo.Cards", "CardType", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderDetail_OrderDetailID", c => c.Int());
            AddColumn("dbo.Orders", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "PurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderDetails", "PurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Songs", "OrderDetail_OrderDetailID", c => c.Int());
            AddColumn("dbo.Songs", "Order_OrderID", c => c.Int());
            AddColumn("dbo.Albums", "Order_OrderID", c => c.Int());
            AddColumn("dbo.Albums", "OrderDetail_OrderDetailID", c => c.Int());
            DropForeignKey("dbo.Cards", "AppUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "SongID", "dbo.Songs");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Carts", "SongID", "dbo.Songs");
            DropForeignKey("dbo.Carts", "AlbumID", "dbo.Albums");
            DropForeignKey("dbo.RatingArtists", "Artist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.RatingArtists", "Rating_RatingID", "dbo.Ratings");
            DropForeignKey("dbo.RatingAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.RatingAlbums", "Rating_RatingID", "dbo.Ratings");
            DropIndex("dbo.RatingArtists", new[] { "Artist_ArtistID" });
            DropIndex("dbo.RatingArtists", new[] { "Rating_RatingID" });
            DropIndex("dbo.RatingAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.RatingAlbums", new[] { "Rating_RatingID" });
            DropIndex("dbo.OrderDetails", new[] { "SongID" });
            DropIndex("dbo.OrderDetails", new[] { "AlbumID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Carts", new[] { "SongID" });
            DropIndex("dbo.Carts", new[] { "AlbumID" });
            DropIndex("dbo.Cards", new[] { "AppUserId" });
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.Int(nullable: false));
            DropColumn("dbo.Cards", "ExpDate");
            DropColumn("dbo.Cards", "CardNumber");
            DropColumn("dbo.Cards", "Type");
            DropColumn("dbo.Cards", "AppUserId");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.Orders", "GiftEmail");
            DropColumn("dbo.Orders", "IsGift");
            DropColumn("dbo.Orders", "Total");
            DropColumn("dbo.Orders", "Tax");
            DropColumn("dbo.Orders", "Subtotal");
            DropColumn("dbo.Orders", "CVV");
            DropColumn("dbo.Orders", "ExpDate");
            DropColumn("dbo.Orders", "CardNumber");
            DropColumn("dbo.Orders", "Type");
            DropColumn("dbo.Orders", "CardID");
            DropColumn("dbo.OrderDetails", "UnitPrice");
            DropColumn("dbo.OrderDetails", "Subtotal");
            DropColumn("dbo.OrderDetails", "Quantity");
            DropColumn("dbo.OrderDetails", "SongID");
            DropColumn("dbo.OrderDetails", "AlbumID");
            DropColumn("dbo.OrderDetails", "OrderID");
            DropColumn("dbo.Songs", "DiscountedPrice");
            DropColumn("dbo.Songs", "DiscountAmount");
            DropColumn("dbo.Albums", "DiscountedPrice");
            DropColumn("dbo.Albums", "DiscountAmount");
            DropTable("dbo.RatingArtists");
            DropTable("dbo.RatingAlbums");
            DropTable("dbo.Carts");
            RenameIndex(table: "dbo.Orders", name: "IX_AppUserId", newName: "IX_AppUsers_Id");
            RenameColumn(table: "dbo.Orders", name: "AppUserId", newName: "AppUsers_Id");
            CreateIndex("dbo.CardAppUsers", "AppUser_Id");
            CreateIndex("dbo.CardAppUsers", "Card_CardID");
            CreateIndex("dbo.Orders", "OrderDetail_OrderDetailID");
            CreateIndex("dbo.Songs", "OrderDetail_OrderDetailID");
            CreateIndex("dbo.Songs", "Order_OrderID");
            CreateIndex("dbo.Albums", "Order_OrderID");
            CreateIndex("dbo.Albums", "OrderDetail_OrderDetailID");
            AddForeignKey("dbo.Songs", "OrderDetail_OrderDetailID", "dbo.OrderDetails", "OrderDetailID");
            AddForeignKey("dbo.Songs", "Order_OrderID", "dbo.Orders", "OrderID");
            AddForeignKey("dbo.Orders", "OrderDetail_OrderDetailID", "dbo.OrderDetails", "OrderDetailID");
            AddForeignKey("dbo.CardAppUsers", "AppUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CardAppUsers", "Card_CardID", "dbo.Cards", "CardID", cascadeDelete: true);
            AddForeignKey("dbo.Albums", "Order_OrderID", "dbo.Orders", "OrderID");
            AddForeignKey("dbo.Albums", "OrderDetail_OrderDetailID", "dbo.OrderDetails", "OrderDetailID");
        }
    }
}
