namespace MIS333KProjectPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        AlbumTitle = c.String(),
                        AlbumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FeaturedAlbum = c.Boolean(nullable: false),
                        OrderDetail_OrderDetailID = c.Int(),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.OrderDetails", t => t.OrderDetail_OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .Index(t => t.OrderDetail_OrderDetailID)
                .Index(t => t.Order_OrderID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        ArtistName = c.String(),
                        FeaturedArtist = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongID = c.Int(nullable: false, identity: true),
                        SongTitle = c.String(),
                        SongPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FeaturedSong = c.Boolean(nullable: false),
                        Order_OrderID = c.Int(),
                        OrderDetail_OrderDetailID = c.Int(),
                    })
                .PrimaryKey(t => t.SongID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .ForeignKey("dbo.OrderDetails", t => t.OrderDetail_OrderDetailID)
                .Index(t => t.Order_OrderID)
                .Index(t => t.OrderDetail_OrderDetailID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        OrderDetail_OrderDetailID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.OrderDetails", t => t.OrderDetail_OrderDetailID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.OrderDetail_OrderDetailID)
                .Index(t => t.User_UserID);
            
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
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        CardID = c.Int(nullable: false, identity: true),
                        Cards1 = c.Int(nullable: false),
                        Card1 = c.Int(nullable: false),
                        ExpDate = c.DateTime(nullable: false),
                        CVV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CardID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        RatingLists = c.Int(nullable: false),
                        AlbumReview_AlbumID = c.Int(),
                        ArtistReview_ArtistID = c.Int(),
                        SongReview_SongID = c.Int(),
                        UserReview_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Albums", t => t.AlbumReview_AlbumID)
                .ForeignKey("dbo.Artists", t => t.ArtistReview_ArtistID)
                .ForeignKey("dbo.Songs", t => t.SongReview_SongID)
                .ForeignKey("dbo.Users", t => t.UserReview_UserID)
                .Index(t => t.AlbumReview_AlbumID)
                .Index(t => t.ArtistReview_ArtistID)
                .Index(t => t.SongReview_SongID)
                .Index(t => t.UserReview_UserID);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingID = c.Int(nullable: false, identity: true),
                        RatingScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RatingID);
            
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
                .PrimaryKey(t => t.ViewModelID)
                .ForeignKey("dbo.Albums", t => t.album_AlbumID)
                .ForeignKey("dbo.Artists", t => t.artist_ArtistID)
                .ForeignKey("dbo.Genres", t => t.genre_GenreID)
                .ForeignKey("dbo.Songs", t => t.song_SongID)
                .Index(t => t.album_AlbumID)
                .Index(t => t.artist_ArtistID)
                .Index(t => t.genre_GenreID)
                .Index(t => t.song_SongID);
            
            CreateTable(
                "dbo.ArtistAlbums",
                c => new
                    {
                        Artist_ArtistID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Artist_ArtistID, t.Album_AlbumID })
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Artist_ArtistID)
                .Index(t => t.Album_AlbumID);
            
            CreateTable(
                "dbo.GenreAlbums",
                c => new
                    {
                        Genre_GenreID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreID, t.Album_AlbumID })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Genre_GenreID)
                .Index(t => t.Album_AlbumID);
            
            CreateTable(
                "dbo.GenreArtists",
                c => new
                    {
                        Genre_GenreID = c.Int(nullable: false),
                        Artist_ArtistID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreID, t.Artist_ArtistID })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID, cascadeDelete: true)
                .Index(t => t.Genre_GenreID)
                .Index(t => t.Artist_ArtistID);
            
            CreateTable(
                "dbo.SongAlbums",
                c => new
                    {
                        Song_SongID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Song_SongID, t.Album_AlbumID })
                .ForeignKey("dbo.Songs", t => t.Song_SongID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Song_SongID)
                .Index(t => t.Album_AlbumID);
            
            CreateTable(
                "dbo.SongArtists",
                c => new
                    {
                        Song_SongID = c.Int(nullable: false),
                        Artist_ArtistID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Song_SongID, t.Artist_ArtistID })
                .ForeignKey("dbo.Songs", t => t.Song_SongID, cascadeDelete: true)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID, cascadeDelete: true)
                .Index(t => t.Song_SongID)
                .Index(t => t.Artist_ArtistID);
            
            CreateTable(
                "dbo.SongGenres",
                c => new
                    {
                        Song_SongID = c.Int(nullable: false),
                        Genre_GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Song_SongID, t.Genre_GenreID })
                .ForeignKey("dbo.Songs", t => t.Song_SongID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .Index(t => t.Song_SongID)
                .Index(t => t.Genre_GenreID);
            
            CreateTable(
                "dbo.CardUsers",
                c => new
                    {
                        Card_CardID = c.Int(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Card_CardID, t.User_UserID })
                .ForeignKey("dbo.Cards", t => t.Card_CardID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.Card_CardID)
                .Index(t => t.User_UserID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ViewModels", "song_SongID", "dbo.Songs");
            DropForeignKey("dbo.ViewModels", "genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.ViewModels", "artist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.ViewModels", "album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.RatingSongs", "Song_SongID", "dbo.Songs");
            DropForeignKey("dbo.RatingSongs", "Rating_RatingID", "dbo.Ratings");
            DropForeignKey("dbo.Songs", "OrderDetail_OrderDetailID", "dbo.OrderDetails");
            DropForeignKey("dbo.Reviews", "UserReview_UserID", "dbo.Users");
            DropForeignKey("dbo.Reviews", "SongReview_SongID", "dbo.Songs");
            DropForeignKey("dbo.Reviews", "ArtistReview_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.Reviews", "AlbumReview_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Orders", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.CardUsers", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.CardUsers", "Card_CardID", "dbo.Cards");
            DropForeignKey("dbo.Songs", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "OrderDetail_OrderDetailID", "dbo.OrderDetails");
            DropForeignKey("dbo.Albums", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Albums", "OrderDetail_OrderDetailID", "dbo.OrderDetails");
            DropForeignKey("dbo.SongGenres", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.SongGenres", "Song_SongID", "dbo.Songs");
            DropForeignKey("dbo.SongArtists", "Artist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.SongArtists", "Song_SongID", "dbo.Songs");
            DropForeignKey("dbo.SongAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.SongAlbums", "Song_SongID", "dbo.Songs");
            DropForeignKey("dbo.GenreArtists", "Artist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.GenreArtists", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.GenreAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.GenreAlbums", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.ArtistAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.ArtistAlbums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.RatingSongs", new[] { "Song_SongID" });
            DropIndex("dbo.RatingSongs", new[] { "Rating_RatingID" });
            DropIndex("dbo.CardUsers", new[] { "User_UserID" });
            DropIndex("dbo.CardUsers", new[] { "Card_CardID" });
            DropIndex("dbo.SongGenres", new[] { "Genre_GenreID" });
            DropIndex("dbo.SongGenres", new[] { "Song_SongID" });
            DropIndex("dbo.SongArtists", new[] { "Artist_ArtistID" });
            DropIndex("dbo.SongArtists", new[] { "Song_SongID" });
            DropIndex("dbo.SongAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.SongAlbums", new[] { "Song_SongID" });
            DropIndex("dbo.GenreArtists", new[] { "Artist_ArtistID" });
            DropIndex("dbo.GenreArtists", new[] { "Genre_GenreID" });
            DropIndex("dbo.GenreAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.GenreAlbums", new[] { "Genre_GenreID" });
            DropIndex("dbo.ArtistAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.ArtistAlbums", new[] { "Artist_ArtistID" });
            DropIndex("dbo.ViewModels", new[] { "song_SongID" });
            DropIndex("dbo.ViewModels", new[] { "genre_GenreID" });
            DropIndex("dbo.ViewModels", new[] { "artist_ArtistID" });
            DropIndex("dbo.ViewModels", new[] { "album_AlbumID" });
            DropIndex("dbo.Reviews", new[] { "UserReview_UserID" });
            DropIndex("dbo.Reviews", new[] { "SongReview_SongID" });
            DropIndex("dbo.Reviews", new[] { "ArtistReview_ArtistID" });
            DropIndex("dbo.Reviews", new[] { "AlbumReview_AlbumID" });
            DropIndex("dbo.Orders", new[] { "User_UserID" });
            DropIndex("dbo.Orders", new[] { "OrderDetail_OrderDetailID" });
            DropIndex("dbo.Songs", new[] { "OrderDetail_OrderDetailID" });
            DropIndex("dbo.Songs", new[] { "Order_OrderID" });
            DropIndex("dbo.Albums", new[] { "Order_OrderID" });
            DropIndex("dbo.Albums", new[] { "OrderDetail_OrderDetailID" });
            DropTable("dbo.RatingSongs");
            DropTable("dbo.CardUsers");
            DropTable("dbo.SongGenres");
            DropTable("dbo.SongArtists");
            DropTable("dbo.SongAlbums");
            DropTable("dbo.GenreArtists");
            DropTable("dbo.GenreAlbums");
            DropTable("dbo.ArtistAlbums");
            DropTable("dbo.ViewModels");
            DropTable("dbo.Ratings");
            DropTable("dbo.Reviews");
            DropTable("dbo.Cards");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Songs");
            DropTable("dbo.Genres");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
