namespace MIS333KProjectPractice.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MIS333KProjectPractice.DAL.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MIS333KProjectPractice.DAL.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            AddSongs.AddGenres();

            AddSongs.AddAlbums();

            AddSongs.AddArtists();

            AddSongs.AddRatings();

            AddSongs.SeedSongs();
        }
    }
}
