namespace MIS333KProjectPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Songs", "Genre_GenreID", "dbo.Genres");
            DropIndex("dbo.Songs", new[] { "Genre_GenreID" });
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
            
            DropColumn("dbo.Songs", "Genre_GenreID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "Genre_GenreID", c => c.Int());
            DropForeignKey("dbo.SongGenres", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.SongGenres", "Song_SongID", "dbo.Songs");
            DropIndex("dbo.SongGenres", new[] { "Genre_GenreID" });
            DropIndex("dbo.SongGenres", new[] { "Song_SongID" });
            DropTable("dbo.SongGenres");
            CreateIndex("dbo.Songs", "Genre_GenreID");
            AddForeignKey("dbo.Songs", "Genre_GenreID", "dbo.Genres", "GenreID");
        }
    }
}
