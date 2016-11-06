using MIS333KProjectPractice.Models;
using MIS333KProjectPractice.DAL;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Collections.Generic;

namespace MIS333KProjectPractice.Migrations  //migration to add data to database
{
    public static class AddSongs
    {
        public static AppDbContext db = new AppDbContext();

        public static void AddGenres()
        {
            //Create new genres
            Genre g1 = new Genre();
            g1.GenreName = "Pop";
            db.Genres.AddOrUpdate(g => g.GenreName, g1);

            Genre g2 = new Genre();
            g2.GenreName = "Alternative";
            db.Genres.AddOrUpdate(g => g.GenreName, g2);

            Genre g3 = new Genre();
            g3.GenreName = "Dance";
            db.Genres.AddOrUpdate(g => g.GenreName, g3);

            Genre g4 = new Genre();
            g4.GenreName = "Country";
            db.Genres.AddOrUpdate(g => g.GenreName, g4);

            Genre g5 = new Genre();
            g5.GenreName = "Hip Hop/Rap";
            db.Genres.AddOrUpdate(g => g.GenreName, g5);

            Genre g6 = new Genre();
            g6.GenreName = "Holiday";
            db.Genres.AddOrUpdate(g => g.GenreName, g6);

            Genre g7 = new Genre();
            g7.GenreName = "Rock";
            db.Genres.AddOrUpdate(g => g.GenreName, g7);

            Genre g8 = new Genre();
            g8.GenreName = "J-Pop";
            db.Genres.AddOrUpdate(g => g.GenreName, g8);

            Genre g9 = new Genre();
            g9.GenreName = "Classical";
            db.Genres.AddOrUpdate(g => g.GenreName, g9);

            Genre g10 = new Genre();
            g10.GenreName = "Soundtrack";
            db.Genres.AddOrUpdate(g => g.GenreName, g10);

            Genre g11 = new Genre();
            g11.GenreName = "Progressive Trance";
            db.Genres.AddOrUpdate(g => g.GenreName, g11);

            Genre g12 = new Genre();
            g12.GenreName = "Comedy";
            db.Genres.AddOrUpdate(g => g.GenreName, g12);

            Genre g13 = new Genre();
            g13.GenreName = "Children's Music";
            db.Genres.AddOrUpdate(g => g.GenreName, g13);

            Genre g14 = new Genre();
            g14.GenreName = "Singer/Songwriter";
            db.Genres.AddOrUpdate(g => g.GenreName, g14);

            Genre g15 = new Genre();
            g15.GenreName = "Nu Metal";
            db.Genres.AddOrUpdate(g => g.GenreName, g15);

            Genre g16 = new Genre();
            g16.GenreName = "Folk";
            db.Genres.AddOrUpdate(g => g.GenreName, g16);


            Genre g17 = new Genre();
            g17.GenreName = "Reggae";
            db.Genres.AddOrUpdate(g => g.GenreName, g17);


            Genre g18 = new Genre(); //declare new genre object and name it g18; like Employee Alex = new Employee();
            g18.GenreName = "House";
            db.Genres.AddOrUpdate(g => g.GenreName, g18);

            //update database
            db.SaveChanges();
        }

        public static void AddAlbums()
        {
            //Create new albums

            Album b1 = new Album();
            b1.AlbumTitle = "Sorry for Party Rocking (Deluxe Version";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b1);

            Album b2 = new Album();
            b2.AlbumTitle = "21";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b2);

            Album b3 = new Album();
            b3.AlbumTitle = "Torches";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b3);

            Album b4 = new Album();
            b4.AlbumTitle = "Hands All Over";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b4);

            Album b5 = new Album();
            b5.AlbumTitle = "Hands All Over (Deluxe Version)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b5);

            Album b6 = new Album();
            b6.AlbumTitle = "Nothing But the Beat";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b6);

            Album b7 = new Album();
            b7.AlbumTitle = "Born This Way";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b7);

            Album b8 = new Album();
            b8.AlbumTitle = "Loud";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b8);

            Album b9 = new Album();
            b9.AlbumTitle = "Red River Blue (Deluxe Version)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b9);

            Album b10 = new Album();
            b10.AlbumTitle = "Pink Friday (Deluxe Version)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b10);

            Album b11 = new Album();
            b11.AlbumTitle = "Watch the Throne (Deluxe Version)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b11);

            Album b12 = new Album();
            b12.AlbumTitle = "Tailgates & Tanlines";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b12);

            Album b13 = new Album();
            b13.AlbumTitle = "The Band Perry";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b13);

            Album b14 = new Album();
            b14.AlbumTitle = "When the Sun Goes Down";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b14);

            Album b15 = new Album();
            b15.AlbumTitle = "Own the Night";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b15);

            Album b16 = new Album();
            b16.AlbumTitle = "Life At Best (Deluxe Version)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b16);

            Album b17 = new Album();
            b17.AlbumTitle = "Songs From the Heart";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b17);

            Album b18 = new Album();
            b18.AlbumTitle = "Chaos and the Calm";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b18);

            Album b19 = new Album();
            b19.AlbumTitle = "My Everything (Deluxe Version)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b19);

            Album b20 = new Album();
            b20.AlbumTitle = "Ceremonials (Deluxe Version)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b20);

            Album b21 = new Album();
            b21.AlbumTitle = "If You're Reading This It's Too Late";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b21);

            Album b22 = new Album();
            b1.AlbumTitle = "Montevallo";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b22);

            Album b23 = new Album();
            b23.AlbumTitle = "X2C";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b23);

            Album b24 = new Album();
            b24.AlbumTitle = "The Best of Bobby McFerrin";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b24);

            Album b25 = new Album();
            b25.AlbumTitle = "Eat Randy - Single";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b25);

            Album b26 = new Album();
            b26.AlbumTitle = "The Duck Song (The Duck and the Lemonade Stand)";
            db.Albums.AddOrUpdate(b => b.AlbumTitle, b26);


            /*Genre g2 = new Genre();
            g2.GenreName = "Alternative";
            db.Genres.AddOrUpdate(g => g.GenreName, g2);

            Genre g3 = new Genre();
            g3.GenreName = "Dance";
            db.Genres.AddOrUpdate(g => g.GenreName, g3);*/
        }

        public static void AddArtists()
        {
            //Create new artists
            Artist a1 = new Artist();
            a1.ArtistName = "LMFAO";
            db.Artists.AddOrUpdate(a => a.ArtistName, a1);

            Artist a2 = new Artist();
            a2.ArtistName = "ADELE";
            db.Artists.AddOrUpdate(a => a.ArtistName, a2);

            Artist a3 = new Artist();
            a3.ArtistName = "Foster the People";
            db.Artists.AddOrUpdate(a => a.ArtistName, a3);

            Artist a4 = new Artist();
            a4.ArtistName = "Maroon 5";
            db.Artists.AddOrUpdate(a => a.ArtistName, a4);

            Artist a5 = new Artist();
            a5.ArtistName = "David Guetta & Usher";
            db.Artists.AddOrUpdate(a => a.ArtistName, a5);

            Artist a6 = new Artist();
            a6.ArtistName = "Lady GaGa";
            db.Artists.AddOrUpdate(a => a.ArtistName, a6);

            Artist a7 = new Artist();
            a7.ArtistName = "Rihanna";
            db.Artists.AddOrUpdate(a => a.ArtistName, a7);

            Artist a8 = new Artist();
            a8.ArtistName = "Blake Shelton";
            db.Artists.AddOrUpdate(a => a.ArtistName, a8);

            Artist a9 = new Artist();
            a9.ArtistName = "Nicki Minaj";
            db.Artists.AddOrUpdate(a => a.ArtistName, a9);

            Artist a10 = new Artist();
            a10.ArtistName = "Kanye West & Jay Z";
            db.Artists.AddOrUpdate(a => a.ArtistName, a10);

            Artist a11 = new Artist();
            a11.ArtistName = "Luke Bryan";
            db.Artists.AddOrUpdate(a => a.ArtistName, a11);

            Artist a12 = new Artist();
            a12.ArtistName = "The Band Perry";
            db.Artists.AddOrUpdate(a => a.ArtistName, a12);

            Artist a13 = new Artist();
            a13.ArtistName = "Selena Gomez & the Scene";
            db.Artists.AddOrUpdate(a => a.ArtistName, a13);

            Artist a14 = new Artist();
            a14.ArtistName = "Lady Antebellum";
            db.Artists.AddOrUpdate(a => a.ArtistName, a14);

            Artist a15 = new Artist();
            a15.ArtistName = "Eli Young Band";
            db.Artists.AddOrUpdate(a => a.ArtistName, a15);

            Artist a16 = new Artist();
            a16.ArtistName = "The Byars Family";
            db.Artists.AddOrUpdate(a => a.ArtistName, a16);

            Artist a17 = new Artist();
            a17.ArtistName = "Drake";
            db.Artists.AddOrUpdate(a => a.ArtistName, a17);

            Artist a18 = new Artist();
            a18.ArtistName = "Gym Class Heroes";
            db.Artists.AddOrUpdate(a => a.ArtistName, a18);

            Artist a19 = new Artist();
            a19.ArtistName = "Justin Bieber";
            db.Artists.AddOrUpdate(a => a.ArtistName, a19);

            Artist a20 = new Artist();
            a20.ArtistName = "Coldplay";
            db.Artists.AddOrUpdate(a => a.ArtistName, a20);

            Artist a21 = new Artist();
            a21.ArtistName = "Snoop Dogg & Wiz Khalifa";
            db.Artists.AddOrUpdate(a => a.ArtistName, a21);

            Artist a22 = new Artist();
            a22.ArtistName = "Cobra Starship";
            db.Artists.AddOrUpdate(a => a.ArtistName, a22);

            Artist a23 = new Artist();
            a23.ArtistName = "Jason Derulo";
            db.Artists.AddOrUpdate(a => a.ArtistName, a23);

            Artist a24 = new Artist();
            a24.ArtistName = "Kelly Clarkson";
            db.Artists.AddOrUpdate(a => a.ArtistName, a24);

            Artist a25 = new Artist();
            a25.ArtistName = "T-Pain";
            db.Artists.AddOrUpdate(a => a.ArtistName, a25);

            Artist a26 = new Artist();
            a26.ArtistName = "Flo Rida";
            db.Artists.AddOrUpdate(a => a.ArtistName, a26);

            Artist a27 = new Artist();
            a27.ArtistName = "DEV";
            db.Artists.AddOrUpdate(a => a.ArtistName, a27);

            Artist a28 = new Artist();
            a28.ArtistName = "Bruno Mars";
            db.Artists.AddOrUpdate(a => a.ArtistName, a28);

            Artist a29 = new Artist();
            a29.ArtistName = "Christina Perri";
            db.Artists.AddOrUpdate(a => a.ArtistName, a29);

            Artist a30 = new Artist();
            a30.ArtistName = "B.o.B";
            db.Artists.AddOrUpdate(a => a.ArtistName, a30);

            Artist a31 = new Artist();
            a31.ArtistName = "Pitbull";
            db.Artists.AddOrUpdate(a => a.ArtistName, a31);

            Artist a32 = new Artist();
            a32.ArtistName = "Wale";
            db.Artists.AddOrUpdate(a => a.ArtistName, a32);

            Artist a33 = new Artist();
            a33.ArtistName = "Alexandra Stan";
            db.Artists.AddOrUpdate(a => a.ArtistName, a33);

            Artist a34 = new Artist();
            a34.ArtistName = "Nickelback";
            db.Artists.AddOrUpdate(a => a.ArtistName, a34);

            Artist a35 = new Artist();
            a35.ArtistName = "Rick Ross";
            db.Artists.AddOrUpdate(a => a.ArtistName, a35);

            Artist a36 = new Artist();
            a36.ArtistName = "Waka Flocka Flame";
            db.Artists.AddOrUpdate(a => a.ArtistName, a36);

            Artist a37 = new Artist();
            a37.ArtistName = "Florence + the Machine";
            db.Artists.AddOrUpdate(a => a.ArtistName, a37);

            Artist a38 = new Artist();
            a38.ArtistName = "Jessie J";
            db.Artists.AddOrUpdate(a => a.ArtistName, a38);

            Artist a39 = new Artist();
            a39.ArtistName = "Martin Solveig & Dragonette";
            db.Artists.AddOrUpdate(a => a.ArtistName, a39);

            Artist a40 = new Artist();
            a40.ArtistName = "Jake Owen";
            db.Artists.AddOrUpdate(a => a.ArtistName, a40);

            Artist a41 = new Artist();
            a41.ArtistName = "Sean Paul";
            db.Artists.AddOrUpdate(a => a.ArtistName, a41);

            Artist a42 = new Artist();
            a42.ArtistName = "Miranda Lambert";
            db.Artists.AddOrUpdate(a => a.ArtistName, a42);

            Artist a43 = new Artist();
            a43.ArtistName = "Hot Chelle Rae";
            db.Artists.AddOrUpdate(a => a.ArtistName, a43);

            Artist a44 = new Artist();
            a44.ArtistName = "Roscoe Dash";
            db.Artists.AddOrUpdate(a => a.ArtistName, a44);

            Artist a45 = new Artist();
            a45.ArtistName = "Chevelle";
            db.Artists.AddOrUpdate(a => a.ArtistName, a45);

            Artist a46 = new Artist();
            a46.ArtistName = "James Bay";
            db.Artists.AddOrUpdate(a => a.ArtistName, a46);

            Artist a47 = new Artist();
            a47.ArtistName = "Ariana Grande";
            db.Artists.AddOrUpdate(a => a.ArtistName, a47);

            Artist a48 = new Artist();
            a48.ArtistName = "Sam Hunt";
            db.Artists.AddOrUpdate(a => a.ArtistName, a48);

            Artist a49 = new Artist();
            a49.ArtistName = "One Direction";
            db.Artists.AddOrUpdate(a => a.ArtistName, a49);

            Artist a50 = new Artist();
            a50.ArtistName = "Nick Jonas";
            db.Artists.AddOrUpdate(a => a.ArtistName, a50);

            Artist a51 = new Artist();
            a51.ArtistName = "Mark Ronson";
            db.Artists.AddOrUpdate(a => a.ArtistName, a51);

            Artist a52 = new Artist();
            a52.ArtistName = "Hozier";
            db.Artists.AddOrUpdate(a => a.ArtistName, a52);

            Artist a53 = new Artist();
            a53.ArtistName = "Kendrick Lamar";
            db.Artists.AddOrUpdate(a => a.ArtistName, a53);

            Artist a54 = new Artist();
            a54.ArtistName = "FLOW";
            db.Artists.AddOrUpdate(a => a.ArtistName, a54);

            Artist a55 = new Artist();
            a55.ArtistName = "Hans Zimmer & James Newton Howard";
            db.Artists.AddOrUpdate(a => a.ArtistName, a55);

            Artist a56 = new Artist();
            a56.ArtistName = "Andain";
            db.Artists.AddOrUpdate(a => a.ArtistName, a56);

            Artist a57 = new Artist();
            a57.ArtistName = "Bryant Oden";
            db.Artists.AddOrUpdate(a => a.ArtistName, a57);

            Artist a58 = new Artist();
            a58.ArtistName = "Jay-Z & Linkin Park";
            db.Artists.AddOrUpdate(a => a.ArtistName, a58);

            Artist a59 = new Artist();
            a59.ArtistName = "Julian Smith";
            db.Artists.AddOrUpdate(a => a.ArtistName, a59);

            Artist a60 = new Artist();
            a60.ArtistName = "Malvina Reynolds";
            db.Artists.AddOrUpdate(a => a.ArtistName, a60);

            Artist a61 = new Artist();
            a61.ArtistName = "Peter, Paul & Mary";
            db.Artists.AddOrUpdate(a => a.ArtistName, a61);

            Artist a62 = new Artist();
            a62.ArtistName = "Bobby McFerrin";
            db.Artists.AddOrUpdate(a => a.ArtistName, a62);

            Artist a63 = new Artist();
            a63.ArtistName = "Calvin Harris";
            db.Artists.AddOrUpdate(a => a.ArtistName, a63);
        }

        public static void AddRatings()
        {
            //Create new reviews
            Rating r1 = new Rating();
            r1.RatingScore = 1;
            db.Ratings.AddOrUpdate(r => r.RatingScore, r1);

            Rating r2 = new Rating();
            r2.RatingScore = 2;
            db.Ratings.AddOrUpdate(r => r.RatingScore, r2);


            /*Review r2 = new Review();
            r2.Rating = 2;
            db.Reviews.AddOrUpdate(r => r.Rating, r2);

            Review r3 = new Review();
            r3.Rating = 3;
            db.Reviews.AddOrUpdate(r => r.Rating, r3);

            Review r4 = new Review();
            r4.Rating = 4;
            db.Reviews.AddOrUpdate(r => r.Rating, r4);

            Review r5 = new Review();
            r5.Rating = 5;
            db.Reviews.AddOrUpdate(r => r.Rating, r5); */

        }

        public static void SeedSongs()

        {

            Song s1 = new Song();

            s1.SongTitle = "Rolling in the Deep";

            s1.SongPrice = 1.29m;

            s1.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s1.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s1.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s1);

            db.SaveChanges();




            Song s2 = new Song();

            s2.SongTitle = "Rumour Has It";

            s2.SongPrice = 0.89m;

            s2.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s2.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s2.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s2);

            db.SaveChanges();




            Song s3 = new Song();

            s3.SongTitle = "Turning Tables";

            s3.SongPrice = 1.29m;

            s3.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s3.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s3.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s3);

            db.SaveChanges();




            Song s4 = new Song();

            s4.SongTitle = "Don't You Remember";

            s4.SongPrice = 1.29m;

            s4.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s4.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s4.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s4);

            db.SaveChanges();




            Song s5 = new Song();

            s5.SongTitle = "Set Fire to the Rain";

            s5.SongPrice = 1.29m;

            s5.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s5.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s5.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s5);

            db.SaveChanges();




            Song s6 = new Song();

            s6.SongTitle = "He Won't Go";

            s6.SongPrice = 1.19m;

            s6.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s6.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s6.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s6);

            db.SaveChanges();




            Song s7 = new Song();

            s7.SongTitle = "Take It All";

            s7.SongPrice = 1.29m;

            s7.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s7.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s7.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s7);

            db.SaveChanges();




            Song s8 = new Song();

            s8.SongTitle = "I'll Be Waiting";

            s8.SongPrice = 1.29m;

            s8.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s8.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s8.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s8);

            db.SaveChanges();




            Song s9 = new Song();

            s9.SongTitle = "One and Only";

            s9.SongPrice = 0.99m;

            s9.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s9.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s9.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s9);

            db.SaveChanges();




            Song s10 = new Song();

            s10.SongTitle = "Lovesong";

            s10.SongPrice = 1.29m;

            s10.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s10.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s10.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s10);

            db.SaveChanges();




            Song s11 = new Song();

            s11.SongTitle = "Someone Like You";

            s11.SongPrice = 0.99m;

            s11.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s11.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s11.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s11);

            db.SaveChanges();




            Song s12 = new Song();

            s12.SongTitle = "I Found a Boy";

            s12.SongPrice = 1.29m;

            s12.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s12.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "21")

};

            s12.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "ADELE")

};

            db.Songs.AddOrUpdate(s => s.SongID, s12);

            db.SaveChanges();




            Song s13 = new Song();

            s13.SongTitle = "Marry the Night";

            s13.SongPrice = 1.29m;

            s13.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s13.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s13.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s13);

            db.SaveChanges();




            Song s14 = new Song();

            s14.SongTitle = "Born This Way";

            s14.SongPrice = 1.29m;

            s14.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s14.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s14.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s14);

            db.SaveChanges();




            Song s15 = new Song();

            s15.SongTitle = "Government Hooker";

            s15.SongPrice = 0.99m;

            s15.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s15.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s15.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s15);

            db.SaveChanges();




            Song s16 = new Song();

            s16.SongTitle = "Judas";

            s16.SongPrice = 1.29m;

            s16.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s16.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s16.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s16);

            db.SaveChanges();




            Song s17 = new Song();

            s17.SongTitle = "Americano";

            s17.SongPrice = 1.29m;

            s17.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s17.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s17.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s17);

            db.SaveChanges();




            Song s18 = new Song();

            s18.SongTitle = "Hair";

            s18.SongPrice = 1.39m;

            s18.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s18.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s18.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s18);

            db.SaveChanges();




            Song s19 = new Song();

            s19.SongTitle = "Bloody Mary";

            s19.SongPrice = 0.89m;

            s19.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s19.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s19.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s19);

            db.SaveChanges();




            Song s20 = new Song();

            s20.SongTitle = "Black Jesus + Amen Fashion";

            s20.SongPrice = 1.29m;

            s20.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s20.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s20.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s20);

            db.SaveChanges();




            Song s21 = new Song();

            s21.SongTitle = "Bad Kids";

            s21.SongPrice = 1.49m;

            s21.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s21.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s21.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s21);

            db.SaveChanges();




            Song s22 = new Song();

            s22.SongTitle = "Fashion of His Love";

            s22.SongPrice = 1.29m;

            s22.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s22.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s22.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s22);

            db.SaveChanges();




            Song s23 = new Song();

            s23.SongTitle = "Highway Unicorn (Road to Love)";

            s23.SongPrice = 1.29m;

            s23.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s23.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s23.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s23);

            db.SaveChanges();




            Song s24 = new Song();

            s24.SongTitle = "Heavy Metal Lover";

            s24.SongPrice = 1.29m;

            s24.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s24.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s24.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s24);

            db.SaveChanges();




            Song s25 = new Song();

            s25.SongTitle = "Electric Chapel";

            s25.SongPrice = 0.89m;

            s25.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s25.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s25.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s25);

            db.SaveChanges();




            Song s26 = new Song();

            s26.SongTitle = "The Queen";

            s26.SongPrice = 1.29m;

            s26.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s26.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s26.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s26);

            db.SaveChanges();




            Song s27 = new Song();

            s27.SongTitle = "You and I";

            s27.SongPrice = 1.29m;

            s27.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s27.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s27.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s27);

            db.SaveChanges();




            Song s28 = new Song();

            s28.SongTitle = "The Edge of Glory";

            s28.SongPrice = 1.29m;

            s28.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s28.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Born This Way")

};

            s28.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady GaGa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s28);

            db.SaveChanges();




            Song s29 = new Song();

            s29.SongTitle = "Only If For A Night";

            s29.SongPrice = 0.99m;

            s29.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s29.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s29.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s29);

            db.SaveChanges();




            Song s30 = new Song();

            s30.SongTitle = "Shake It Out";

            s30.SongPrice = 1.29m;

            s30.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s30.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s30.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s30);

            db.SaveChanges();




            Song s31 = new Song();

            s31.SongTitle = "What the Water Gave Me";

            s31.SongPrice = 0.99m;

            s31.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s31.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s31.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s31);

            db.SaveChanges();




            Song s32 = new Song();

            s32.SongTitle = "Never Let Me Go";

            s32.SongPrice = 0.99m;

            s32.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s32.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s32.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s32);

            db.SaveChanges();




            Song s33 = new Song();

            s33.SongTitle = "Breaking Down";

            s33.SongPrice = 0.99m;

            s33.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s33.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s33.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s33);

            db.SaveChanges();




            Song s34 = new Song();

            s34.SongTitle = "Lover to Lover";

            s34.SongPrice = 0.99m;

            s34.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s34.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s34.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s34);

            db.SaveChanges();




            Song s35 = new Song();

            s35.SongTitle = "No Light, No Light";

            s35.SongPrice = 0.99m;

            s35.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s35.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s35.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s35);

            db.SaveChanges();




            Song s36 = new Song();

            s36.SongTitle = "Seven Devils";

            s36.SongPrice = 1.29m;

            s36.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s36.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s36.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s36);

            db.SaveChanges();




            Song s37 = new Song();

            s37.SongTitle = "Heartlines";

            s37.SongPrice = 0.99m;

            s37.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s37.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s37.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s37);

            db.SaveChanges();




            Song s38 = new Song();

            s38.SongTitle = "Spectrum";

            s38.SongPrice = 1.29m;

            s38.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s38.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s38.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s38);

            db.SaveChanges();




            Song s39 = new Song();

            s39.SongTitle = "All of This and Heaven Too";

            s39.SongPrice = 0.99m;

            s39.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s39.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s39.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s39);

            db.SaveChanges();




            Song s40 = new Song();

            s40.SongTitle = "Leave My Body";

            s40.SongPrice = 0.99m;

            s40.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s40.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s40.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s40);

            db.SaveChanges();




            Song s41 = new Song();

            s41.SongTitle = "Remain Nameless";

            s41.SongPrice = 0.99m;

            s41.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s41.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s41.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s41);

            db.SaveChanges();




            Song s42 = new Song();

            s42.SongTitle = "Strangeness and Charm";

            s42.SongPrice = 0.99m;

            s42.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s42.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s42.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s42);

            db.SaveChanges();




            Song s43 = new Song();

            s43.SongTitle = "Bedroom Hymns";

            s43.SongPrice = 0.99m;

            s43.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s43.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s43.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s43);

            db.SaveChanges();




            Song s44 = new Song();

            s44.SongTitle = "What the Water Gave Me (Demo)";

            s44.SongPrice = 0.99m;

            s44.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s44.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Ceremonials (Deluxe Version)")

};

            s44.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s44);

            db.SaveChanges();




            Song s45 = new Song();

            s45.SongTitle = "Craving";

            s45.SongPrice = 1.29m;

            s45.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s45.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s45.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s45);

            db.SaveChanges();




            Song s46 = new Song();

            s46.SongTitle = "Hold Back the River";

            s46.SongPrice = 1.29m;

            s46.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s46.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s46.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s46);

            db.SaveChanges();




            Song s47 = new Song();

            s47.SongTitle = "Let it Go";

            s47.SongPrice = 1.29m;

            s47.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s47.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s47.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s47);

            db.SaveChanges();




            Song s48 = new Song();

            s48.SongTitle = "If You Ever Want to Be in Love";

            s48.SongPrice = 1.29m;

            s48.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s48.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s48.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s48);

            db.SaveChanges();




            Song s49 = new Song();

            s49.SongTitle = "Best Fake Smile";

            s49.SongPrice = 1.29m;

            s49.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s49.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s49.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s49);

            db.SaveChanges();




            Song s50 = new Song();

            s50.SongTitle = "When We Were on Fire";

            s50.SongPrice = 1.29m;

            s50.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s50.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s50.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s50);

            db.SaveChanges();




            Song s51 = new Song();

            s51.SongTitle = "Move Together";

            s51.SongPrice = 1.29m;

            s51.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s51.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s51.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s51);

            db.SaveChanges();




            Song s52 = new Song();

            s52.SongTitle = "Scars";

            s52.SongPrice = 1.29m;

            s52.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s52.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s52.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s52);

            db.SaveChanges();




            Song s53 = new Song();

            s53.SongTitle = "Collide";

            s53.SongPrice = 1.29m;

            s53.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s53.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s53.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s53);

            db.SaveChanges();




            Song s54 = new Song();

            s54.SongTitle = "Get Out While You Can";

            s54.SongPrice = 1.29m;

            s54.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s54.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s54.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s54);

            db.SaveChanges();




            Song s55 = new Song();

            s55.SongTitle = "Need the Sun to Break";

            s55.SongPrice = 1.29m;

            s55.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s55.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s55.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s55);

            db.SaveChanges();




            Song s56 = new Song();

            s56.SongTitle = "Incomplete";

            s56.SongPrice = 1.29m;

            s56.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s56.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Chaos and the Calm")

};

            s56.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "James Bay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s56);

            db.SaveChanges();




            Song s57 = new Song();

            s57.SongTitle = "Eat Randy";

            s57.SongPrice = 1.29m;

            s57.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Comedy")

};

            s57.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Eat Randy - Single")

};

            s57.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Julian Smith")

};

            db.Songs.AddOrUpdate(s => s.SongID, s57);

            db.SaveChanges();




            Song s58 = new Song();

            s58.SongTitle = "Misery";

            s58.SongPrice = 0.99m;

            s58.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s58.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s58.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s58);

            db.SaveChanges();




            Song s59 = new Song();

            s59.SongTitle = "Give a Little More";

            s59.SongPrice = 1.29m;

            s59.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s59.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s59.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s59);

            db.SaveChanges();




            Song s60 = new Song();

            s60.SongTitle = "Stutter";

            s60.SongPrice = 1.29m;

            s60.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s60.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s60.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s60);

            db.SaveChanges();




            Song s61 = new Song();

            s61.SongTitle = "Don't Know Nothing";

            s61.SongPrice = 1.39m;

            s61.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s61.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s61.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s61);

            db.SaveChanges();




            Song s62 = new Song();

            s62.SongTitle = "Never Gonna Leave This Bed";

            s62.SongPrice = 0.89m;

            s62.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s62.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s62.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s62);

            db.SaveChanges();




            Song s63 = new Song();

            s63.SongTitle = "I Can't Lie";

            s63.SongPrice = 1.29m;

            s63.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s63.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s63.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s63);

            db.SaveChanges();




            Song s64 = new Song();

            s64.SongTitle = "Hands All Over";

            s64.SongPrice = 1.49m;

            s64.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s64.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s64.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s64);

            db.SaveChanges();




            Song s65 = new Song();

            s65.SongTitle = "How";

            s65.SongPrice = 1.29m;

            s65.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s65.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s65.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s65);

            db.SaveChanges();




            Song s66 = new Song();

            s66.SongTitle = "Get Back In My Life";

            s66.SongPrice = 1.29m;

            s66.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s66.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s66.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s66);

            db.SaveChanges();




            Song s67 = new Song();

            s67.SongTitle = "Just a Feeling";

            s67.SongPrice = 1.29m;

            s67.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s67.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s67.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s67);

            db.SaveChanges();




            Song s68 = new Song();

            s68.SongTitle = "Runaway";

            s68.SongPrice = 0.89m;

            s68.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s68.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s68.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s68);

            db.SaveChanges();




            Song s69 = new Song();

            s69.SongTitle = "Out of Goodbyes";

            s69.SongPrice = 1.29m;

            s69.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s69.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s69.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s69);

            db.SaveChanges();




            Song s70 = new Song();

            s70.SongTitle = "Moves Like Jagger";

            s70.SongPrice = 1.29m;

            s70.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s70.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s70.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s70);

            db.SaveChanges();




            Song s71 = new Song();

            s71.SongTitle = "The Air That I Breathe";

            s71.SongPrice = 1.29m;

            s71.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s71.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over")

};

            s71.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s71);

            db.SaveChanges();




            Song s72 = new Song();

            s72.SongTitle = "Misery";

            s72.SongPrice = 0.99m;

            s72.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s72.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s72.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s72);

            db.SaveChanges();




            Song s73 = new Song();

            s73.SongTitle = "Give a Little More";

            s73.SongPrice = 1.29m;

            s73.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s73.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s73.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s73);

            db.SaveChanges();




            Song s74 = new Song();

            s74.SongTitle = "Stutter";

            s74.SongPrice = 1.29m;

            s74.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s74.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s74.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s74);

            db.SaveChanges();




            Song s75 = new Song();

            s75.SongTitle = "Don't Know Nothing";

            s75.SongPrice = 1.39m;

            s75.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s75.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s75.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s75);

            db.SaveChanges();




            Song s76 = new Song();

            s76.SongTitle = "Never Gonna Leave This Bed";

            s76.SongPrice = 0.89m;

            s76.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s76.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s76.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s76);

            db.SaveChanges();




            Song s77 = new Song();

            s77.SongTitle = "I Can't Lie";

            s77.SongPrice = 1.29m;

            s77.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s77.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s77.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s77);

            db.SaveChanges();




            Song s78 = new Song();

            s78.SongTitle = "Hands All Over";

            s78.SongPrice = 1.49m;

            s78.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s78.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s78.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s78);

            db.SaveChanges();




            Song s79 = new Song();

            s79.SongTitle = "How";

            s79.SongPrice = 1.29m;

            s79.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s79.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s79.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s79);

            db.SaveChanges();




            Song s80 = new Song();

            s80.SongTitle = "Get Back In My Life";

            s80.SongPrice = 1.29m;

            s80.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s80.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s80.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s80);

            db.SaveChanges();




            Song s81 = new Song();

            s81.SongTitle = "Just a Feeling";

            s81.SongPrice = 1.29m;

            s81.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s81.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s81.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s81);

            db.SaveChanges();




            Song s82 = new Song();

            s82.SongTitle = "Runaway";

            s82.SongPrice = 0.89m;

            s82.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s82.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s82.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s82);

            db.SaveChanges();




            Song s83 = new Song();

            s83.SongTitle = "Out of Goodbyes";

            s83.SongPrice = 1.29m;

            s83.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s83.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s83.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s83);

            db.SaveChanges();




            Song s84 = new Song();

            s84.SongTitle = "Moves Like Jagger";

            s84.SongPrice = 1.29m;

            s84.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s84.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s84.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s84);

            db.SaveChanges();




            Song s85 = new Song();

            s85.SongTitle = "Last Change";

            s85.SongPrice = 1.29m;

            s85.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s85.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s85.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s85);

            db.SaveChanges();




            Song s86 = new Song();

            s86.SongTitle = "No Curtain Call";

            s86.SongPrice = 1.19m;

            s86.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s86.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s86.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s86);

            db.SaveChanges();




            Song s87 = new Song();

            s87.SongTitle = "If I Ain't Got You";

            s87.SongPrice = 1.29m;

            s87.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s87.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s87.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s87);

            db.SaveChanges();




            Song s88 = new Song();

            s88.SongTitle = "The Air That I Breathe";

            s88.SongPrice = 1.29m;

            s88.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s88.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Hands All Over (Deluxe Version)")

};

            s88.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Maroon 5")

};

            db.Songs.AddOrUpdate(s => s.SongID, s88);

            db.SaveChanges();




            Song s89 = new Song();

            s89.SongTitle = "Legend";

            s89.SongPrice = 0.99m;

            s89.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s89.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s89.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s89);

            db.SaveChanges();




            Song s90 = new Song();

            s90.SongTitle = "Energy";

            s90.SongPrice = 1.19m;

            s90.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s90.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s90.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s90);

            db.SaveChanges();




            Song s91 = new Song();

            s91.SongTitle = "10 Bands";

            s91.SongPrice = 0.99m;

            s91.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s91.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s91.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s91);

            db.SaveChanges();




            Song s92 = new Song();

            s92.SongTitle = "Know Yourself";

            s92.SongPrice = 0.99m;

            s92.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s92.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s92.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s92);

            db.SaveChanges();




            Song s93 = new Song();

            s93.SongTitle = "No Tellin'";

            s93.SongPrice = 0.99m;

            s93.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s93.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s93.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s93);

            db.SaveChanges();




            Song s94 = new Song();

            s94.SongTitle = "Madonna";

            s94.SongPrice = 0.99m;

            s94.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s94.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s94.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s94);

            db.SaveChanges();




            Song s95 = new Song();

            s95.SongTitle = "6 God";

            s95.SongPrice = 0.99m;

            s95.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s95.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s95.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s95);

            db.SaveChanges();




            Song s96 = new Song();

            s96.SongTitle = "Star67";

            s96.SongPrice = 0.99m;

            s96.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s96.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s96.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s96);

            db.SaveChanges();




            Song s97 = new Song();

            s97.SongTitle = "Preach (feat. PARTYNEXTDOOR)";

            s97.SongPrice = 0.99m;

            s97.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s97.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s97.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s97);

            db.SaveChanges();




            Song s98 = new Song();

            s98.SongTitle = "Used To (feat. Lil Wayne)";

            s98.SongPrice = 0.99m;

            s98.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s98.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s98.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s98);

            db.SaveChanges();




            Song s99 = new Song();

            s99.SongTitle = "6 Man";

            s99.SongPrice = 0.99m;

            s99.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s99.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s99.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s99);

            db.SaveChanges();




            Song s100 = new Song();

            s100.SongTitle = "Now & Forever";

            s100.SongPrice = 0.99m;

            s100.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s100.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s100.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s100);

            db.SaveChanges();




            Song s101 = new Song();

            s101.SongTitle = "Company (feat. Travi$ Scott)";

            s101.SongPrice = 0.99m;

            s101.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s101.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s101.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s101);

            db.SaveChanges();




            Song s102 = new Song();

            s102.SongTitle = "You & The 6";

            s102.SongPrice = 0.99m;

            s102.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s102.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s102.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s102);

            db.SaveChanges();




            Song s103 = new Song();

            s103.SongTitle = "Jungle";

            s103.SongPrice = 0.99m;

            s103.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s103.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s103.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s103);

            db.SaveChanges();




            Song s104 = new Song();

            s104.SongTitle = "6PM In New York";

            s104.SongPrice = 1.19m;

            s104.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s104.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "If You're Reading This It's Too Late")

};

            s104.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s104);

            db.SaveChanges();




            Song s105 = new Song();

            s105.SongTitle = "Even If It Breaks Your heart";

            s105.SongPrice = 1.29m;

            s105.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s105.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s105.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s105);

            db.SaveChanges();




            Song s106 = new Song();

            s106.SongTitle = "Crazy Girl";

            s106.SongPrice = 0.89m;

            s106.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s106.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s106.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s106);

            db.SaveChanges();




            Song s107 = new Song();

            s107.SongTitle = "Every Other Memory";

            s107.SongPrice = 1.29m;

            s107.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s107.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s107.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s107);

            db.SaveChanges();




            Song s108 = new Song();

            s108.SongTitle = "On My Way";

            s108.SongPrice = 1.29m;

            s108.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s108.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s108.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s108);

            db.SaveChanges();




            Song s109 = new Song();

            s109.SongTitle = "Skeletons";

            s109.SongPrice = 0.99m;

            s109.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s109.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s109.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s109);

            db.SaveChanges();




            Song s110 = new Song();

            s110.SongTitle = "I Love Your";

            s110.SongPrice = 1.29m;

            s110.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s110.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s110.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s110);

            db.SaveChanges();




            Song s111 = new Song();

            s111.SongTitle = "The Fight";

            s111.SongPrice = 0.89m;

            s111.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s111.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s111.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s111);

            db.SaveChanges();




            Song s112 = new Song();

            s112.SongTitle = "My Old Man's Son";

            s112.SongPrice = 1.29m;

            s112.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s112.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s112.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s112);

            db.SaveChanges();




            Song s113 = new Song();

            s113.SongTitle = "Recover";

            s113.SongPrice = 1.49m;

            s113.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s113.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s113.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s113);

            db.SaveChanges();




            Song s114 = new Song();

            s114.SongTitle = "The Falling";

            s114.SongPrice = 1.29m;

            s114.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s114.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s114.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s114);

            db.SaveChanges();




            Song s115 = new Song();

            s115.SongTitle = "War On a Desperate Man";

            s115.SongPrice = 1.29m;

            s115.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s115.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s115.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s115);

            db.SaveChanges();




            Song s116 = new Song();

            s116.SongTitle = "Say Goodnight";

            s116.SongPrice = 0.99m;

            s116.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s116.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s116.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s116);

            db.SaveChanges();




            Song s117 = new Song();

            s117.SongTitle = "How Quickly You Forget";

            s117.SongPrice = 1.29m;

            s117.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s117.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s117.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s117);

            db.SaveChanges();




            Song s118 = new Song();

            s118.SongTitle = "Life At Best";

            s118.SongPrice = 1.29m;

            s118.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s118.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s118.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s118);

            db.SaveChanges();




            Song s119 = new Song();

            s119.SongTitle = "Room Goes Dark (Demo)";

            s119.SongPrice = 1.39m;

            s119.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s119.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s119.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s119);

            db.SaveChanges();




            Song s120 = new Song();

            s120.SongTitle = "Go Outside and Dance";

            s120.SongPrice = 0.89m;

            s120.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s120.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s120.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s120);

            db.SaveChanges();




            Song s121 = new Song();

            s121.SongTitle = "Me and Jack (Demo)";

            s121.SongPrice = 1.29m;

            s121.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s121.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Life At Best (Deluxe Version)")

};

            s121.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Eli Young Band")

};

            db.Songs.AddOrUpdate(s => s.SongID, s121);

            db.SaveChanges();




            Song s122 = new Song();

            s122.SongTitle = "S&M";

            s122.SongPrice = 1.19m;

            s122.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s122.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s122.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s122);

            db.SaveChanges();




            Song s123 = new Song();

            s123.SongTitle = "What's My Name?";

            s123.SongPrice = 1.29m;

            s123.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s123.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s123.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s123);

            db.SaveChanges();




            Song s124 = new Song();

            s124.SongTitle = "Cheers";

            s124.SongPrice = 1.29m;

            s124.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s124.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s124.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s124);

            db.SaveChanges();




            Song s125 = new Song();

            s125.SongTitle = "Fading";

            s125.SongPrice = 0.99m;

            s125.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s125.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s125.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s125);

            db.SaveChanges();




            Song s126 = new Song();

            s126.SongTitle = "Only Girl (In the World)";

            s126.SongPrice = 1.29m;

            s126.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s126.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s126.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s126);

            db.SaveChanges();




            Song s127 = new Song();

            s127.SongTitle = "California King Bed";

            s127.SongPrice = 0.99m;

            s127.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s127.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s127.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s127);

            db.SaveChanges();




            Song s128 = new Song();

            s128.SongTitle = "Man Down";

            s128.SongPrice = 1.29m;

            s128.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s128.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s128.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s128);

            db.SaveChanges();




            Song s129 = new Song();

            s129.SongTitle = "Raining Men";

            s129.SongPrice = 1.29m;

            s129.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s129.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s129.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s129);

            db.SaveChanges();




            Song s130 = new Song();

            s130.SongTitle = "Complicated";

            s130.SongPrice = 0.89m;

            s130.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s130.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s130.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s130);

            db.SaveChanges();




            Song s131 = new Song();

            s131.SongTitle = "Skin";

            s131.SongPrice = 1.29m;

            s131.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s131.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s131.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s131);

            db.SaveChanges();




            Song s132 = new Song();

            s132.SongTitle = "Love The Way You Lie";

            s132.SongPrice = 1.29m;

            s132.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s132.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Loud")

};

            s132.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rihanna")

};

            db.Songs.AddOrUpdate(s => s.SongID, s132);

            db.SaveChanges();




            Song s133 = new Song();

            s133.SongTitle = "Take Your Time";

            s133.SongPrice = 1.19m;

            s133.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s133.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s133.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s133);

            db.SaveChanges();




            Song s134 = new Song();

            s134.SongTitle = "Leave the Night On";

            s134.SongPrice = 1.19m;

            s134.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s134.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s134.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s134);

            db.SaveChanges();




            Song s135 = new Song();

            s135.SongTitle = "House Party";

            s135.SongPrice = 0.99m;

            s135.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s135.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s135.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s135);

            db.SaveChanges();




            Song s136 = new Song();

            s136.SongTitle = "Break Up in a Small Town";

            s136.SongPrice = 0.99m;

            s136.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s136.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s136.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s136);

            db.SaveChanges();




            Song s137 = new Song();

            s137.SongTitle = "Single for the Summer";

            s137.SongPrice = 0.89m;

            s137.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s137.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s137.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s137);

            db.SaveChanges();




            Song s138 = new Song();

            s138.SongTitle = "Ex to See";

            s138.SongPrice = 0.99m;

            s138.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s138.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s138.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s138);

            db.SaveChanges();




            Song s139 = new Song();

            s139.SongTitle = "Make You Miss Me";

            s139.SongPrice = 0.89m;

            s139.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s139.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s139.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s139);

            db.SaveChanges();




            Song s140 = new Song();

            s140.SongTitle = "Cop Car";

            s140.SongPrice = 0.99m;

            s140.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s140.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s140.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s140);

            db.SaveChanges();




            Song s141 = new Song();

            s141.SongTitle = "Raised on It";

            s141.SongPrice = 0.99m;

            s141.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s141.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s141.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s141);

            db.SaveChanges();




            Song s142 = new Song();

            s142.SongTitle = "Speakers";

            s142.SongPrice = 0.99m;

            s142.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s142.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Montevallo")

};

            s142.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s142);

            db.SaveChanges();




            Song s143 = new Song();

            s143.SongTitle = "Intro";

            s143.SongPrice = 0.89m;

            s143.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s143.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s143.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s143);

            db.SaveChanges();




            Song s144 = new Song();

            s144.SongTitle = "Problem (feat. Iggy Azalea)";

            s144.SongPrice = 1.29m;

            s144.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s144.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s144.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s144);

            db.SaveChanges();




            Song s145 = new Song();

            s145.SongTitle = "One Last Time";

            s145.SongPrice = 1.29m;

            s145.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s145.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s145.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s145);

            db.SaveChanges();




            Song s146 = new Song();

            s146.SongTitle = "Why Try";

            s146.SongPrice = 0.99m;

            s146.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s146.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s146.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s146);

            db.SaveChanges();




            Song s147 = new Song();

            s147.SongTitle = "Break Free (feat. Zedd)";

            s147.SongPrice = 1.29m;

            s147.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s147.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s147.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s147);

            db.SaveChanges();




            Song s148 = new Song();

            s148.SongTitle = "Best Mistake (feat. Big Sean)";

            s148.SongPrice = 0.99m;

            s148.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s148.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s148.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s148);

            db.SaveChanges();




            Song s149 = new Song();

            s149.SongTitle = "Be My Baby (feat. Cashmere Cat)";

            s149.SongPrice = 0.99m;

            s149.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s149.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s149.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s149);

            db.SaveChanges();




            Song s150 = new Song();

            s150.SongTitle = "Break Your Heart Right Back (feat. Childish Gambino)";

            s150.SongPrice = 0.99m;

            s150.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s150.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s150.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s150);

            db.SaveChanges();




            Song s151 = new Song();

            s151.SongTitle = "Love Me Harder (feat. The Weeknd)";

            s151.SongPrice = 1.29m;

            s151.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s151.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s151.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s151);

            db.SaveChanges();




            Song s152 = new Song();

            s152.SongTitle = "Just a Little Bit of Your Heart";

            s152.SongPrice = 0.99m;

            s152.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s152.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s152.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s152);

            db.SaveChanges();




            Song s153 = new Song();

            s153.SongTitle = "Hands On Me (feat. A$AP Ferg)";

            s153.SongPrice = 0.99m;

            s153.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s153.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s153.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s153);

            db.SaveChanges();




            Song s154 = new Song();

            s154.SongTitle = "My Everything";

            s154.SongPrice = 0.99m;

            s154.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s154.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s154.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s154);

            db.SaveChanges();




            Song s155 = new Song();

            s155.SongTitle = "Bang Bang (feat. Jessie J and Nicki Minaj)";

            s155.SongPrice = 1.29m;

            s155.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s155.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s155.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s155);

            db.SaveChanges();




            Song s156 = new Song();

            s156.SongTitle = "Only 1";

            s156.SongPrice = 0.89m;

            s156.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s156.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s156.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s156);

            db.SaveChanges();




            Song s157 = new Song();

            s157.SongTitle = "You Don't Know Me";

            s157.SongPrice = 0.99m;

            s157.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s157.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "My Everything (Deluxe Version)")

};

            s157.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Ariana Grande")

};

            db.Songs.AddOrUpdate(s => s.SongID, s157);

            db.SaveChanges();




            Song s158 = new Song();

            s158.SongTitle = "Where Them Girls At";

            s158.SongPrice = 0.99m;

            s158.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s158.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s158.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s158);

            db.SaveChanges();




            Song s159 = new Song();

            s159.SongTitle = "Little Bad Girl";

            s159.SongPrice = 1.29m;

            s159.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s159.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s159.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s159);

            db.SaveChanges();




            Song s160 = new Song();

            s160.SongTitle = "Turn Me On";

            s160.SongPrice = 0.99m;

            s160.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s160.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s160.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s160);

            db.SaveChanges();




            Song s161 = new Song();

            s161.SongTitle = "Sweat";

            s161.SongPrice = 1.29m;

            s161.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s161.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s161.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s161);

            db.SaveChanges();




            Song s162 = new Song();

            s162.SongTitle = "Without You";

            s162.SongPrice = 1.29m;

            s162.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s162.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s162.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s162);

            db.SaveChanges();




            Song s163 = new Song();

            s163.SongTitle = "Nothing Really Matters";

            s163.SongPrice = 0.89m;

            s163.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s163.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s163.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s163);

            db.SaveChanges();




            Song s164 = new Song();

            s164.SongTitle = "I Can Only Imagine";

            s164.SongPrice = 1.29m;

            s164.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s164.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s164.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s164);

            db.SaveChanges();




            Song s165 = new Song();

            s165.SongTitle = "Crank It Up";

            s165.SongPrice = 1.29m;

            s165.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s165.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s165.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s165);

            db.SaveChanges();




            Song s166 = new Song();

            s166.SongTitle = "Lunar";

            s166.SongPrice = 0.99m;

            s166.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s166.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s166.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s166);

            db.SaveChanges();




            Song s167 = new Song();

            s167.SongTitle = "Night of Your Life";

            s167.SongPrice = 1.29m;

            s167.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s167.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s167.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s167);

            db.SaveChanges();




            Song s168 = new Song();

            s168.SongTitle = "Repeate";

            s168.SongPrice = 0.89m;

            s168.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s168.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s168.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s168);

            db.SaveChanges();




            Song s169 = new Song();

            s169.SongTitle = "Titanium";

            s169.SongPrice = 1.29m;

            s169.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s169.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s169.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s169);

            db.SaveChanges();




            Song s170 = new Song();

            s170.SongTitle = "I'm a Machine";

            s170.SongPrice = 1.49m;

            s170.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance, House")

};

            s170.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Nothing But the Beat")

};

            s170.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "David Guetta & Usher")

};

            db.Songs.AddOrUpdate(s => s.SongID, s170);

            db.SaveChanges();




            Song s171 = new Song();

            s171.SongTitle = "We Owned the Night";

            s171.SongPrice = 1.29m;

            s171.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s171.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s171.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s171);

            db.SaveChanges();




            Song s172 = new Song();

            s172.SongTitle = "Just a Kiss";

            s172.SongPrice = 0.89m;

            s172.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s172.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s172.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s172);

            db.SaveChanges();




            Song s173 = new Song();

            s173.SongTitle = "Dancin' Away With My Heart";

            s173.SongPrice = 1.29m;

            s173.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s173.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s173.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s173);

            db.SaveChanges();




            Song s174 = new Song();

            s174.SongTitle = "Friday Night";

            s174.SongPrice = 1.29m;

            s174.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s174.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s174.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s174);

            db.SaveChanges();




            Song s175 = new Song();

            s175.SongTitle = "When You Were Mine";

            s175.SongPrice = 1.29m;

            s175.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s175.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s175.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s175);

            db.SaveChanges();




            Song s176 = new Song();

            s176.SongTitle = "Cold As Stone";

            s176.SongPrice = 1.19m;

            s176.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s176.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s176.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s176);

            db.SaveChanges();




            Song s177 = new Song();

            s177.SongTitle = "Singing Me Home";

            s177.SongPrice = 1.29m;

            s177.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s177.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s177.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s177);

            db.SaveChanges();




            Song s178 = new Song();

            s178.SongTitle = "Wanted You More";

            s178.SongPrice = 1.29m;

            s178.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s178.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s178.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s178);

            db.SaveChanges();




            Song s179 = new Song();

            s179.SongTitle = "As You Turn Aay";

            s179.SongPrice = 0.99m;

            s179.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s179.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s179.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s179);

            db.SaveChanges();




            Song s180 = new Song();

            s180.SongTitle = "Love I've Found In You";

            s180.SongPrice = 1.29m;

            s180.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s180.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s180.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s180);

            db.SaveChanges();




            Song s181 = new Song();

            s181.SongTitle = "Somewhere Love Remains";

            s181.SongPrice = 0.99m;

            s181.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s181.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s181.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s181);

            db.SaveChanges();




            Song s182 = new Song();

            s182.SongTitle = "Heart of the World";

            s182.SongPrice = 1.29m;

            s182.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s182.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Own the Night")

};

            s182.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Lady Antebellum")

};

            db.Songs.AddOrUpdate(s => s.SongID, s182);

            db.SaveChanges();




            Song s183 = new Song();

            s183.SongTitle = "I'm the Best";

            s183.SongPrice = 1.49m;

            s183.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s183.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s183.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s183);

            db.SaveChanges();




            Song s184 = new Song();

            s184.SongTitle = "Roman's Revenge";

            s184.SongPrice = 1.29m;

            s184.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s184.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s184.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s184);

            db.SaveChanges();




            Song s185 = new Song();

            s185.SongTitle = "Did It On'em";

            s185.SongPrice = 1.29m;

            s185.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s185.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s185.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s185);

            db.SaveChanges();




            Song s186 = new Song();

            s186.SongTitle = "Right Thru Me";

            s186.SongPrice = 1.29m;

            s186.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s186.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s186.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s186);

            db.SaveChanges();




            Song s187 = new Song();

            s187.SongTitle = "Fly";

            s187.SongPrice = 0.89m;

            s187.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s187.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s187.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s187);

            db.SaveChanges();




            Song s188 = new Song();

            s188.SongTitle = "Save Me";

            s188.SongPrice = 1.29m;

            s188.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s188.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s188.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s188);

            db.SaveChanges();




            Song s189 = new Song();

            s189.SongTitle = "Moment 4 Life";

            s189.SongPrice = 1.29m;

            s189.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s189.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s189.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s189);

            db.SaveChanges();




            Song s190 = new Song();

            s190.SongTitle = "Check It Out";

            s190.SongPrice = 1.29m;

            s190.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s190.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s190.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s190);

            db.SaveChanges();




            Song s191 = new Song();

            s191.SongTitle = "Blazin'";

            s191.SongPrice = 1.19m;

            s191.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s191.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s191.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s191);

            db.SaveChanges();




            Song s192 = new Song();

            s192.SongTitle = "Here I Am";

            s192.SongPrice = 1.29m;

            s192.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s192.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s192.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s192);

            db.SaveChanges();




            Song s193 = new Song();

            s193.SongTitle = "Dear Old Nicki";

            s193.SongPrice = 1.29m;

            s193.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s193.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s193.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s193);

            db.SaveChanges();




            Song s194 = new Song();

            s194.SongTitle = "Your Love";

            s194.SongPrice = 0.99m;

            s194.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s194.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s194.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s194);

            db.SaveChanges();




            Song s195 = new Song();

            s195.SongTitle = "Last Chance";

            s195.SongPrice = 1.29m;

            s195.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s195.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s195.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s195);

            db.SaveChanges();




            Song s196 = new Song();

            s196.SongTitle = "Super Bass";

            s196.SongPrice = 0.99m;

            s196.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s196.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s196.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s196);

            db.SaveChanges();




            Song s197 = new Song();

            s197.SongTitle = "Blow Ya Mind";

            s197.SongPrice = 1.29m;

            s197.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s197.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s197.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s197);

            db.SaveChanges();




            Song s198 = new Song();

            s198.SongTitle = "Muny";

            s198.SongPrice = 1.29m;

            s198.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s198.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s198.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s198);

            db.SaveChanges();




            Song s199 = new Song();

            s199.SongTitle = "Girls Fall Like Dominoes";

            s199.SongPrice = 0.89m;

            s199.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s199.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Pink Friday (Deluxe Version)")

};

            s199.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nicki Minaj")

};

            db.Songs.AddOrUpdate(s => s.SongID, s199);

            db.SaveChanges();




            Song s200 = new Song();

            s200.SongTitle = "Honey Bee";

            s200.SongPrice = 0.99m;

            s200.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s200.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s200.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s200);

            db.SaveChanges();




            Song s201 = new Song();

            s201.SongTitle = "Ready to Roll";

            s201.SongPrice = 1.29m;

            s201.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s201.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s201.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s201);

            db.SaveChanges();




            Song s202 = new Song();

            s202.SongTitle = "God Gave Me You";

            s202.SongPrice = 0.89m;

            s202.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s202.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s202.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s202);

            db.SaveChanges();




            Song s203 = new Song();

            s203.SongTitle = "Get Some";

            s203.SongPrice = 1.29m;

            s203.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s203.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s203.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s203);

            db.SaveChanges();




            Song s204 = new Song();

            s204.SongTitle = "Drink On It";

            s204.SongPrice = 1.49m;

            s204.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s204.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s204.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s204);

            db.SaveChanges();




            Song s205 = new Song();

            s205.SongTitle = "Good Ole Boys";

            s205.SongPrice = 1.29m;

            s205.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s205.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s205.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s205);

            db.SaveChanges();




            Song s206 = new Song();

            s206.SongTitle = "I'm Sorry";

            s206.SongPrice = 1.29m;

            s206.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s206.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s206.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s206);

            db.SaveChanges();




            Song s207 = new Song();

            s207.SongTitle = "Sunny In Seattle";

            s207.SongPrice = 0.99m;

            s207.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s207.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s207.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s207);

            db.SaveChanges();




            Song s208 = new Song();

            s208.SongTitle = "Over";

            s208.SongPrice = 1.29m;

            s208.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s208.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s208.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s208);

            db.SaveChanges();




            Song s209 = new Song();

            s209.SongTitle = "Hey";

            s209.SongPrice = 1.29m;

            s209.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s209.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s209.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s209);

            db.SaveChanges();




            Song s210 = new Song();

            s210.SongTitle = "Red River Blue";

            s210.SongPrice = 1.39m;

            s210.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s210.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s210.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s210);

            db.SaveChanges();




            Song s211 = new Song();

            s211.SongTitle = "Chili";

            s211.SongPrice = 0.89m;

            s211.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s211.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s211.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s211);

            db.SaveChanges();




            Song s212 = new Song();

            s212.SongTitle = "Addicted";

            s212.SongPrice = 1.29m;

            s212.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country, Pop")

};

            s212.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Red River Blue (Deluxe Version)")

};

            s212.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Blake Shelton")

};

            db.Songs.AddOrUpdate(s => s.SongID, s212);

            db.SaveChanges();




            Song s213 = new Song();

            s213.SongTitle = "Ruby";

            s213.SongPrice = 1.49m;

            s213.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s213.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s213.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s213);

            db.SaveChanges();




            Song s214 = new Song();

            s214.SongTitle = "Old School";

            s214.SongPrice = 1.29m;

            s214.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s214.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s214.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s214);

            db.SaveChanges();




            Song s215 = new Song();

            s215.SongTitle = "Dancing In The Rain";

            s215.SongPrice = 1.29m;

            s215.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s215.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s215.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s215);

            db.SaveChanges();




            Song s216 = new Song();

            s216.SongTitle = "He's My Brother";

            s216.SongPrice = 1.29m;

            s216.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s216.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s216.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s216);

            db.SaveChanges();




            Song s217 = new Song();

            s217.SongTitle = "Lady Of Darkness";

            s217.SongPrice = 0.89m;

            s217.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s217.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s217.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s217);

            db.SaveChanges();




            Song s218 = new Song();

            s218.SongTitle = "Red Haired Beauty";

            s218.SongPrice = 1.29m;

            s218.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s218.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s218.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s218);

            db.SaveChanges();




            Song s219 = new Song();

            s219.SongTitle = "Once In A Life";

            s219.SongPrice = 1.29m;

            s219.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s219.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s219.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s219);

            db.SaveChanges();




            Song s220 = new Song();

            s220.SongTitle = "Life At The Doublewide";

            s220.SongPrice = 1.29m;

            s220.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s220.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s220.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s220);

            db.SaveChanges();




            Song s221 = new Song();

            s221.SongTitle = "Isabelle";

            s221.SongPrice = 1.19m;

            s221.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s221.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s221.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s221);

            db.SaveChanges();




            Song s222 = new Song();

            s222.SongTitle = "The Waltz";

            s222.SongPrice = 1.29m;

            s222.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s222.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s222.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s222);

            db.SaveChanges();




            Song s223 = new Song();

            s223.SongTitle = "Me And Eddy B";

            s223.SongPrice = 1.29m;

            s223.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s223.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Songs From the Heart")

};

            s223.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Byars Family")

};

            db.Songs.AddOrUpdate(s => s.SongID, s223);

            db.SaveChanges();




            Song s224 = new Song();

            s224.SongTitle = "Rock the Beat 2";

            s224.SongPrice = 1.29m;

            s224.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s224.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s224.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s224);

            db.SaveChanges();




            Song s225 = new Song();

            s225.SongTitle = "Sorry for Party Rocking";

            s225.SongPrice = 1.49m;

            s225.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s225.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s225.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s225);

            db.SaveChanges();




            Song s226 = new Song();

            s226.SongTitle = "Party Rock Anthem";

            s226.SongPrice = 1.29m;

            s226.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s226.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s226.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s226);

            db.SaveChanges();




            Song s227 = new Song();

            s227.SongTitle = "Sexy and I Know It";

            s227.SongPrice = 1.29m;

            s227.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s227.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s227.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s227);

            db.SaveChanges();




            Song s228 = new Song();

            s228.SongTitle = "Champagne Showers";

            s228.SongPrice = 0.99m;

            s228.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s228.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s228.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s228);

            db.SaveChanges();




            Song s229 = new Song();

            s229.SongTitle = "One Day";

            s229.SongPrice = 1.29m;

            s229.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s229.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s229.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s229);

            db.SaveChanges();




            Song s230 = new Song();

            s230.SongTitle = "Take It to the Hole";

            s230.SongPrice = 1.29m;

            s230.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s230.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s230.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s230);

            db.SaveChanges();




            Song s231 = new Song();

            s231.SongTitle = "We Came Here to Party";

            s231.SongPrice = 1.39m;

            s231.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s231.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s231.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s231);

            db.SaveChanges();




            Song s232 = new Song();

            s232.SongTitle = "Reminds Me of You";

            s232.SongPrice = 0.89m;

            s232.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s232.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s232.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s232);

            db.SaveChanges();




            Song s233 = new Song();

            s233.SongTitle = "Best Night";

            s233.SongPrice = 1.29m;

            s233.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s233.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s233.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s233);

            db.SaveChanges();




            Song s234 = new Song();

            s234.SongTitle = "All Night Long";

            s234.SongPrice = 1.49m;

            s234.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s234.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s234.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s234);

            db.SaveChanges();




            Song s235 = new Song();

            s235.SongTitle = "With You";

            s235.SongPrice = 1.29m;

            s235.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s235.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s235.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s235);

            db.SaveChanges();




            Song s236 = new Song();

            s236.SongTitle = "Hot Dog";

            s236.SongPrice = 1.29m;

            s236.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s236.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Sorry for Party Rocking (Deluxe Version)")

};

            s236.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "LMFAO")

};

            db.Songs.AddOrUpdate(s => s.SongID, s236);

            db.SaveChanges();




            Song s237 = new Song();

            s237.SongTitle = "Country Girl (Shake It for Me)";

            s237.SongPrice = 1.29m;

            s237.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s237.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s237.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s237);

            db.SaveChanges();




            Song s238 = new Song();

            s238.SongTitle = "Kiss Tomorrow Goodbye";

            s238.SongPrice = 1.49m;

            s238.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s238.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s238.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s238);

            db.SaveChanges();




            Song s239 = new Song();

            s239.SongTitle = "Drunk On You";

            s239.SongPrice = 1.29m;

            s239.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s239.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s239.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s239);

            db.SaveChanges();




            Song s240 = new Song();

            s240.SongTitle = "Too Damn Young";

            s240.SongPrice = 1.29m;

            s240.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s240.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s240.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s240);

            db.SaveChanges();




            Song s241 = new Song();

            s241.SongTitle = "I Don't Want This Night to End";

            s241.SongPrice = 1.29m;

            s241.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s241.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s241.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s241);

            db.SaveChanges();




            Song s242 = new Song();

            s242.SongTitle = "You Don't Know Jack";

            s242.SongPrice = 0.89m;

            s242.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s242.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s242.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s242);

            db.SaveChanges();




            Song s243 = new Song();

            s243.SongTitle = "Harvest Time";

            s243.SongPrice = 1.29m;

            s243.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s243.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s243.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s243);

            db.SaveChanges();




            Song s244 = new Song();

            s244.SongTitle = "I Know You're Gonna Be There";

            s244.SongPrice = 1.29m;

            s244.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s244.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s244.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s244);

            db.SaveChanges();




            Song s245 = new Song();

            s245.SongTitle = "Muckalee Creek Water";

            s245.SongPrice = 1.29m;

            s245.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s245.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s245.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s245);

            db.SaveChanges();




            Song s246 = new Song();

            s246.SongTitle = "Tailgate Blues";

            s246.SongPrice = 1.19m;

            s246.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s246.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s246.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s246);

            db.SaveChanges();




            Song s247 = new Song();

            s247.SongTitle = "Been There, Done That";

            s247.SongPrice = 1.29m;

            s247.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s247.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s247.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s247);

            db.SaveChanges();




            Song s248 = new Song();

            s248.SongTitle = "Faded Away";

            s248.SongPrice = 1.29m;

            s248.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s248.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s248.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s248);

            db.SaveChanges();




            Song s249 = new Song();

            s249.SongTitle = "I knew You That Way";

            s249.SongPrice = 0.99m;

            s249.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s249.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Tailgates & Tanlines")

};

            s249.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Luke Bryan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s249);

            db.SaveChanges();




            Song s250 = new Song();

            s250.SongTitle = "If I Die Young";

            s250.SongPrice = 1.29m;

            s250.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s250.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s250.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s250);

            db.SaveChanges();




            Song s251 = new Song();

            s251.SongTitle = "All Your Life";

            s251.SongPrice = 0.99m;

            s251.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s251.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s251.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s251);

            db.SaveChanges();




            Song s252 = new Song();

            s252.SongTitle = "You Lie";

            s252.SongPrice = 1.29m;

            s252.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s252.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s252.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s252);

            db.SaveChanges();




            Song s253 = new Song();

            s253.SongTitle = "Hip to My Heart";

            s253.SongPrice = 1.29m;

            s253.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s253.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s253.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s253);

            db.SaveChanges();




            Song s254 = new Song();

            s254.SongTitle = "Walk Me Down the Middle";

            s254.SongPrice = 0.89m;

            s254.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s254.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s254.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s254);

            db.SaveChanges();




            Song s255 = new Song();

            s255.SongTitle = "Independence";

            s255.SongPrice = 1.29m;

            s255.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s255.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s255.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s255);

            db.SaveChanges();




            Song s256 = new Song();

            s256.SongTitle = "Lasso";

            s256.SongPrice = 1.29m;

            s256.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s256.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s256.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s256);

            db.SaveChanges();




            Song s257 = new Song();

            s257.SongTitle = "Postcard from Paris";

            s257.SongPrice = 0.99m;

            s257.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s257.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s257.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s257);

            db.SaveChanges();




            Song s258 = new Song();

            s258.SongTitle = "Quittin' You";

            s258.SongPrice = 1.29m;

            s258.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s258.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s258.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s258);

            db.SaveChanges();




            Song s259 = new Song();

            s259.SongTitle = "Miss You Being Gone";

            s259.SongPrice = 0.89m;

            s259.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s259.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s259.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s259);

            db.SaveChanges();




            Song s260 = new Song();

            s260.SongTitle = "Double Heart";

            s260.SongPrice = 1.29m;

            s260.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s260.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Band Perry")

};

            s260.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "The Band Perry")

};

            db.Songs.AddOrUpdate(s => s.SongID, s260);

            db.SaveChanges();




            Song s261 = new Song();

            s261.SongTitle = "Don't Worry, Be Happy";

            s261.SongPrice = 1.29m;

            s261.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s261.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s261.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s261);

            db.SaveChanges();




            Song s262 = new Song();

            s262.SongTitle = "Friends";

            s262.SongPrice = 1.29m;

            s262.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s262.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s262.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s262);

            db.SaveChanges();




            Song s263 = new Song();

            s263.SongTitle = "Thinkin' About Your Body";

            s263.SongPrice = 1.29m;

            s263.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s263.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s263.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s263);

            db.SaveChanges();




            Song s264 = new Song();

            s264.SongTitle = "Spain";

            s264.SongPrice = 1.29m;

            s264.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s264.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s264.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s264);

            db.SaveChanges();




            Song s265 = new Song();

            s265.SongTitle = "Freedom is a Voice";

            s265.SongPrice = 1.29m;

            s265.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s265.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s265.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s265);

            db.SaveChanges();




            Song s266 = new Song();

            s266.SongTitle = "Drive My Car";

            s266.SongPrice = 1.29m;

            s266.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s266.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s266.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s266);

            db.SaveChanges();




            Song s267 = new Song();

            s267.SongTitle = "Another Night In Tunsia";

            s267.SongPrice = 1.29m;

            s267.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s267.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s267.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s267);

            db.SaveChanges();




            Song s268 = new Song();

            s268.SongTitle = "Blue Bossa";

            s268.SongPrice = 1.29m;

            s268.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s268.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s268.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s268);

            db.SaveChanges();




            Song s269 = new Song();

            s269.SongTitle = "Turtle Shoes";

            s269.SongPrice = 1.29m;

            s269.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s269.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s269.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s269);

            db.SaveChanges();




            Song s270 = new Song();

            s270.SongTitle = "Good Lovin'";

            s270.SongPrice = 1.29m;

            s270.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s270.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s270.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s270);

            db.SaveChanges();




            Song s271 = new Song();

            s271.SongTitle = "From Me to You";

            s271.SongPrice = 1.29m;

            s271.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s271.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s271.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s271);

            db.SaveChanges();




            Song s272 = new Song();

            s272.SongTitle = "Bang!Zoom";

            s272.SongPrice = 1.29m;

            s272.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Reggae")

};

            s272.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Best of Bobby McFerrin")

};

            s272.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bobby McFerrin")

};

            db.Songs.AddOrUpdate(s => s.SongID, s272);

            db.SaveChanges();




            Song s273 = new Song();

            s273.SongTitle = "The Duck Song";

            s273.SongPrice = 0.99m;

            s273.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Comedy, Chidren's Music, Singer/Songwriter")

};

            s273.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "The Duck Song (The Duck and the Lemonade Stand)")

};

            s273.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bryant Oden")

};

            db.Songs.AddOrUpdate(s => s.SongID, s273);

            db.SaveChanges();




            Song s274 = new Song();

            s274.SongTitle = "Helena Beat";

            s274.SongPrice = 1.29m;

            s274.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s274.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s274.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s274);

            db.SaveChanges();




            Song s275 = new Song();

            s275.SongTitle = "Pumped Up Kicks";

            s275.SongPrice = 0.89m;

            s275.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s275.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s275.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s275);

            db.SaveChanges();




            Song s276 = new Song();

            s276.SongTitle = "Call It What You Want";

            s276.SongPrice = 1.29m;

            s276.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s276.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s276.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s276);

            db.SaveChanges();




            Song s277 = new Song();

            s277.SongTitle = "Don't Stop (Color On the Walls)";

            s277.SongPrice = 1.29m;

            s277.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s277.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s277.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s277);

            db.SaveChanges();




            Song s278 = new Song();

            s278.SongTitle = "Waste";

            s278.SongPrice = 0.99m;

            s278.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s278.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s278.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s278);

            db.SaveChanges();




            Song s279 = new Song();

            s279.SongTitle = "I Would Do Anything for You";

            s279.SongPrice = 1.29m;

            s279.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s279.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s279.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s279);

            db.SaveChanges();




            Song s280 = new Song();

            s280.SongTitle = "Houdini";

            s280.SongPrice = 0.89m;

            s280.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s280.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s280.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s280);

            db.SaveChanges();




            Song s281 = new Song();

            s281.SongTitle = "Life On the Nickel";

            s281.SongPrice = 1.29m;

            s281.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s281.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s281.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s281);

            db.SaveChanges();




            Song s282 = new Song();

            s282.SongTitle = "Miss You";

            s282.SongPrice = 1.49m;

            s282.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s282.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s282.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s282);

            db.SaveChanges();




            Song s283 = new Song();

            s283.SongTitle = "Warrant";

            s283.SongPrice = 1.29m;

            s283.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s283.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s283.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s283);

            db.SaveChanges();




            Song s284 = new Song();

            s284.SongTitle = "Broken Jaw";

            s284.SongPrice = 1.29m;

            s284.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s284.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Torches")

};

            s284.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Foster the People")

};

            db.Songs.AddOrUpdate(s => s.SongID, s284);

            db.SaveChanges();




            Song s285 = new Song();

            s285.SongTitle = "No Church in the Wild";

            s285.SongPrice = 1.29m;

            s285.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s285.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s285.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s285);

            db.SaveChanges();




            Song s286 = new Song();

            s286.SongTitle = "Lift Off";

            s286.SongPrice = 1.29m;

            s286.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s286.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s286.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s286);

            db.SaveChanges();




            Song s287 = new Song();

            s287.SongTitle = "Otis";

            s287.SongPrice = 0.99m;

            s287.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s287.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s287.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s287);

            db.SaveChanges();




            Song s288 = new Song();

            s288.SongTitle = "Gotta Have It";

            s288.SongPrice = 1.29m;

            s288.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s288.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s288.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s288);

            db.SaveChanges();




            Song s289 = new Song();

            s289.SongTitle = "New Day";

            s289.SongPrice = 0.89m;

            s289.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s289.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s289.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s289);

            db.SaveChanges();




            Song s290 = new Song();

            s290.SongTitle = "That's My Bitch";

            s290.SongPrice = 1.29m;

            s290.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s290.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s290.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s290);

            db.SaveChanges();




            Song s291 = new Song();

            s291.SongTitle = "Welcome to the Jungle";

            s291.SongPrice = 1.49m;

            s291.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s291.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s291.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s291);

            db.SaveChanges();




            Song s292 = new Song();

            s292.SongTitle = "Who Gon Stop Me";

            s292.SongPrice = 1.29m;

            s292.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s292.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s292.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s292);

            db.SaveChanges();




            Song s293 = new Song();

            s293.SongTitle = "Murder to Excellence";

            s293.SongPrice = 1.29m;

            s293.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s293.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s293.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s293);

            db.SaveChanges();




            Song s294 = new Song();

            s294.SongTitle = "Made in America";

            s294.SongPrice = 0.99m;

            s294.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s294.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s294.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s294);

            db.SaveChanges();




            Song s295 = new Song();

            s295.SongTitle = "Why I Love You";

            s295.SongPrice = 1.29m;

            s295.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s295.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s295.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s295);

            db.SaveChanges();




            Song s296 = new Song();

            s296.SongTitle = "H*a*m";

            s296.SongPrice = 1.29m;

            s296.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s296.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s296.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s296);

            db.SaveChanges();




            Song s297 = new Song();

            s297.SongTitle = "Primetime";

            s297.SongPrice = 1.39m;

            s297.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s297.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s297.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s297);

            db.SaveChanges();




            Song s298 = new Song();

            s298.SongTitle = "The Joy";

            s298.SongPrice = 0.89m;

            s298.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s298.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "Watch the Throne (Deluxe Version)")

};

            s298.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kanye West & JAY Z")

};

            db.Songs.AddOrUpdate(s => s.SongID, s298);

            db.SaveChanges();




            Song s299 = new Song();

            s299.SongTitle = "Love You Like a Love Song";

            s299.SongPrice = 1.49m;

            s299.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s299.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s299.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s299);

            db.SaveChanges();




            Song s300 = new Song();

            s300.SongTitle = "Bang Bang Bang";

            s300.SongPrice = 1.29m;

            s300.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s300.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s300.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s300);

            db.SaveChanges();




            Song s301 = new Song();

            s301.SongTitle = "Who Says";

            s301.SongPrice = 1.29m;

            s301.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s301.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s301.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s301);

            db.SaveChanges();




            Song s302 = new Song();

            s302.SongTitle = "We Own the Night";

            s302.SongPrice = 0.99m;

            s302.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s302.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s302.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s302);

            db.SaveChanges();




            Song s303 = new Song();

            s303.SongTitle = "Hit the Lights";

            s303.SongPrice = 1.29m;

            s303.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s303.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s303.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s303);

            db.SaveChanges();




            Song s304 = new Song();

            s304.SongTitle = "Whiplash";

            s304.SongPrice = 1.29m;

            s304.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s304.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s304.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s304);

            db.SaveChanges();




            Song s305 = new Song();

            s305.SongTitle = "When the Sun Goes Down";

            s305.SongPrice = 1.39m;

            s305.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s305.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s305.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s305);

            db.SaveChanges();




            Song s306 = new Song();

            s306.SongTitle = "My Dilemma";

            s306.SongPrice = 0.89m;

            s306.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s306.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s306.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s306);

            db.SaveChanges();




            Song s307 = new Song();

            s307.SongTitle = "That's More Like It";

            s307.SongPrice = 1.29m;

            s307.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s307.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s307.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s307);

            db.SaveChanges();




            Song s308 = new Song();

            s308.SongTitle = "Outlaw";

            s308.SongPrice = 1.49m;

            s308.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s308.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s308.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s308);

            db.SaveChanges();




            Song s309 = new Song();

            s309.SongTitle = "Middle of Nowhere";

            s309.SongPrice = 1.29m;

            s309.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s309.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s309.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s309);

            db.SaveChanges();




            Song s310 = new Song();

            s310.SongTitle = "Dices";

            s310.SongPrice = 1.29m;

            s310.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s310.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "When the Sun Goes Down")

};

            s310.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Selena Gomez & the Scene")

};

            db.Songs.AddOrUpdate(s => s.SongID, s310);

            db.SaveChanges();




            Song s311 = new Song();

            s311.SongTitle = "Leave the Night On";

            s311.SongPrice = 1.19m;

            s311.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s311.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "X2C")

};

            s311.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s311);

            db.SaveChanges();




            Song s312 = new Song();

            s312.SongTitle = "Ex to See";

            s312.SongPrice = 0.99m;

            s312.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s312.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "X2C")

};

            s312.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s312);

            db.SaveChanges();




            Song s313 = new Song();

            s313.SongTitle = "House Party";

            s313.SongPrice = 0.99m;

            s313.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s313.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "X2C")

};

            s313.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s313);

            db.SaveChanges();




            Song s314 = new Song();

            s314.SongTitle = "Break Up in a Small Town";

            s314.SongPrice = 0.89m;

            s314.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s314.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "X2C")

};

            s314.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sam Hunt")

};

            db.Songs.AddOrUpdate(s => s.SongID, s314);

            db.SaveChanges();




            Song s315 = new Song();

            s315.SongTitle = "Answer";

            s315.SongPrice = 1.29m;

            s315.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop, J-Pop")

};

            s315.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s315.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "FLOW")

};

            db.Songs.AddOrUpdate(s => s.SongID, s315);

            db.SaveChanges();




            Song s316 = new Song();

            s316.SongTitle = "Antrozous";

            s316.SongPrice = 1.29m;

            s316.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Classical, Soundtrack")

};

            s316.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s316.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Hans Zimmer & James Newton Howard")

};

            db.Songs.AddOrUpdate(s => s.SongID, s316);

            db.SaveChanges();




            Song s317 = new Song();

            s317.SongTitle = "Beautiful Things (Gabriel & Dresden Radio Mix)";

            s317.SongPrice = 1.29m;

            s317.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Progressive Trance, Dance")

};

            s317.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s317.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Andain")

};

            db.Songs.AddOrUpdate(s => s.SongID, s317);

            db.SaveChanges();




            Song s318 = new Song();

            s318.SongTitle = "Numb/Encore";

            s318.SongPrice = 1.29m;

            s318.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative, Nu Metal, Hip Hop/Rap")

};

            s318.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s318.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Jay-Z & Linkin Park")

};

            db.Songs.AddOrUpdate(s => s.SongID, s318);

            db.SaveChanges();




            Song s319 = new Song();

            s319.SongTitle = "Little Boxes";

            s319.SongPrice = 1.29m;

            s319.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Folk")

};

            s319.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s319.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Malvina Reynolds")

};

            db.Songs.AddOrUpdate(s => s.SongID, s319);

            db.SaveChanges();




            Song s320 = new Song();

            s320.SongTitle = "Puff, the Magic Dragon";

            s320.SongPrice = 1.29m;

            s320.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Singer/Songwriter")

};

            s320.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s320.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Peter, Paul & Mary")

};

            db.Songs.AddOrUpdate(s => s.SongID, s320);

            db.SaveChanges();




            Song s321 = new Song();

            s321.SongTitle = "We Found Love (feat. Rihanna)";

            s321.SongPrice = 1.29m;

            s321.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s321.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s321.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Calvin Harris")

};

            db.Songs.AddOrUpdate(s => s.SongID, s321);

            db.SaveChanges();




            Song s322 = new Song();

            s322.SongTitle = "Stereo Hearts (feat. Adam Levine)";

            s322.SongPrice = 1.29m;

            s322.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s322.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s322.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Gym Class Heroes")

};

            db.Songs.AddOrUpdate(s => s.SongID, s322);

            db.SaveChanges();




            Song s323 = new Song();

            s323.SongTitle = "Mistletoe";

            s323.SongPrice = 1.29m;

            s323.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Holiday")

};

            s323.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s323.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Justin Bieber")

};

            db.Songs.AddOrUpdate(s => s.SongID, s323);

            db.SaveChanges();




            Song s324 = new Song();

            s324.SongTitle = "Paradise";

            s324.SongPrice = 0.99m;

            s324.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s324.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s324.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Coldplay")

};

            db.Songs.AddOrUpdate(s => s.SongID, s324);

            db.SaveChanges();




            Song s325 = new Song();

            s325.SongTitle = "Young, Wild & Free (feat. Bruno Mars)";

            s325.SongPrice = 1.29m;

            s325.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s325.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s325.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Snoop Dogg & Wiz Khalifa")

};

            db.Songs.AddOrUpdate(s => s.SongID, s325);

            db.SaveChanges();




            Song s326 = new Song();

            s326.SongTitle = "You Make Me Feel... (feat. Sabi)";

            s326.SongPrice = 1.29m;

            s326.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s326.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s326.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Cobra Starship")

};

            db.Songs.AddOrUpdate(s => s.SongID, s326);

            db.SaveChanges();




            Song s327 = new Song();

            s327.SongTitle = "It Girl";

            s327.SongPrice = 1.39m;

            s327.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s327.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s327.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Jason Derulo")

};

            db.Songs.AddOrUpdate(s => s.SongID, s327);

            db.SaveChanges();




            Song s328 = new Song();

            s328.SongTitle = "Mr. Know It All";

            s328.SongPrice = 0.89m;

            s328.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s328.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s328.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kelly Clarkson")

};

            db.Songs.AddOrUpdate(s => s.SongID, s328);

            db.SaveChanges();




            Song s329 = new Song();

            s329.SongTitle = "5 O'Clock (feat. Wiz Khalifa & Lily Allen)";

            s329.SongPrice = 1.29m;

            s329.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s329.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s329.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "T-Pain")

};

            db.Songs.AddOrUpdate(s => s.SongID, s329);

            db.SaveChanges();




            Song s330 = new Song();

            s330.SongTitle = "Good Feeling";

            s330.SongPrice = 1.49m;

            s330.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s330.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s330.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Flo Rida")

};

            db.Songs.AddOrUpdate(s => s.SongID, s330);

            db.SaveChanges();




            Song s331 = new Song();

            s331.SongTitle = "In the Dark";

            s331.SongPrice = 1.29m;

            s331.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s331.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s331.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "DEV")

};

            db.Songs.AddOrUpdate(s => s.SongID, s331);

            db.SaveChanges();




            Song s332 = new Song();

            s332.SongTitle = "It Will Rain";

            s332.SongPrice = 1.29m;

            s332.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s332.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s332.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Bruno Mars")

};

            db.Songs.AddOrUpdate(s => s.SongID, s332);

            db.SaveChanges();




            Song s333 = new Song();

            s333.SongTitle = "A Thousand Years";

            s333.SongPrice = 0.89m;

            s333.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s333.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s333.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Christina Perri")

};

            db.Songs.AddOrUpdate(s => s.SongID, s333);

            db.SaveChanges();




            Song s334 = new Song();

            s334.SongTitle = "Strange Clouds (feat. Lil Wayne)";

            s334.SongPrice = 1.29m;

            s334.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s334.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s334.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "B.o.B")

};

            db.Songs.AddOrUpdate(s => s.SongID, s334);

            db.SaveChanges();




            Song s335 = new Song();

            s335.SongTitle = "Give Me Everything (feat. Ne-Yo, Afrojack & Nayer)";

            s335.SongPrice = 1.29m;

            s335.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s335.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s335.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Pitbull")

};

            db.Songs.AddOrUpdate(s => s.SongID, s335);

            db.SaveChanges();




            Song s336 = new Song();

            s336.SongTitle = "Focused (feat. Kid Cudi)";

            s336.SongPrice = 1.29m;

            s336.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s336.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s336.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Wale")

};

            db.Songs.AddOrUpdate(s => s.SongID, s336);

            db.SaveChanges();




            Song s337 = new Song();

            s337.SongTitle = "Mr. Saxobeat (Radio Edit)";

            s337.SongPrice = 1.19m;

            s337.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance")

};

            s337.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s337.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Alexandra Stan")

};

            db.Songs.AddOrUpdate(s => s.SongID, s337);

            db.SaveChanges();




            Song s338 = new Song();

            s338.SongTitle = "When We Stand Together";

            s338.SongPrice = 1.29m;

            s338.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Rock")

};

            s338.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s338.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nickelback")

};

            db.Songs.AddOrUpdate(s => s.SongID, s338);

            db.SaveChanges();




            Song s339 = new Song();

            s339.SongTitle = "You the Boss (feat. Nicki Minaj)";

            s339.SongPrice = 1.29m;

            s339.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s339.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s339.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Rick Ross")

};

            db.Songs.AddOrUpdate(s => s.SongID, s339);

            db.SaveChanges();




            Song s340 = new Song();

            s340.SongTitle = "Round of Applause (feat. Drake)";

            s340.SongPrice = 0.99m;

            s340.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s340.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s340.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Waka Flocka Flame")

};

            db.Songs.AddOrUpdate(s => s.SongID, s340);

            db.SaveChanges();




            Song s341 = new Song();

            s341.SongTitle = "Shake It Out";

            s341.SongPrice = 1.29m;

            s341.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s341.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s341.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Florence + the Machine")

};

            db.Songs.AddOrUpdate(s => s.SongID, s341);

            db.SaveChanges();




            Song s342 = new Song();

            s342.SongTitle = "Domino";

            s342.SongPrice = 0.99m;

            s342.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s342.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s342.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Jessie J")

};

            db.Songs.AddOrUpdate(s => s.SongID, s342);

            db.SaveChanges();




            Song s343 = new Song();

            s343.SongTitle = "Hello";

            s343.SongPrice = 1.29m;

            s343.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Dance")

};

            s343.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s343.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Martin Solveig & Dragonette")

};

            db.Songs.AddOrUpdate(s => s.SongID, s343);

            db.SaveChanges();




            Song s344 = new Song();

            s344.SongTitle = "Barefoot Blue Jean Night";

            s344.SongPrice = 1.29m;

            s344.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s344.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s344.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Jake Owen")

};

            db.Songs.AddOrUpdate(s => s.SongID, s344);

            db.SaveChanges();




            Song s345 = new Song();

            s345.SongTitle = "Marvins Room";

            s345.SongPrice = 0.89m;

            s345.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s345.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s345.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Drake")

};

            db.Songs.AddOrUpdate(s => s.SongID, s345);

            db.SaveChanges();




            Song s346 = new Song();

            s346.SongTitle = "Got 2 Luv U (feat. Alexis Jordan)";

            s346.SongPrice = 1.29m;

            s346.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s346.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s346.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Sean Paul")

};

            db.Songs.AddOrUpdate(s => s.SongID, s346);

            db.SaveChanges();




            Song s347 = new Song();

            s347.SongTitle = "Baggage Claim";

            s347.SongPrice = 1.29m;

            s347.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Country")

};

            s347.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s347.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Miranda Lambert")

};

            db.Songs.AddOrUpdate(s => s.SongID, s347);

            db.SaveChanges();




            Song s348 = new Song();

            s348.SongTitle = "I Like It Like That (feat. New Boyz)";

            s348.SongPrice = 0.99m;

            s348.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s348.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s348.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Hot Chelle Rae")

};

            db.Songs.AddOrUpdate(s => s.SongID, s348);

            db.SaveChanges();




            Song s349 = new Song();

            s349.SongTitle = "Good Good Night";

            s349.SongPrice = 1.29m;

            s349.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s349.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s349.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Roscoe Dash")

};

            db.Songs.AddOrUpdate(s => s.SongID, s349);

            db.SaveChanges();




            Song s350 = new Song();

            s350.SongTitle = "Face to the Floor";

            s350.SongPrice = 0.89m;

            s350.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Rock")

};

            s350.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s350.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Chevelle")

};

            db.Songs.AddOrUpdate(s => s.SongID, s350);

            db.SaveChanges();




            Song s351 = new Song();

            s351.SongTitle = "Steal My Girl";

            s351.SongPrice = 1.29m;

            s351.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s351.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s351.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "One Direction")

};

            db.Songs.AddOrUpdate(s => s.SongID, s351);

            db.SaveChanges();




            Song s352 = new Song();

            s352.SongTitle = "Jealous";

            s352.SongPrice = 0.99m;

            s352.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s352.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s352.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Nick Jonas")

};

            db.Songs.AddOrUpdate(s => s.SongID, s352);

            db.SaveChanges();




            Song s353 = new Song();

            s353.SongTitle = "Uptown Funk (ft. Bruno Mars)";

            s353.SongPrice = 1.19m;

            s353.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Pop")

};

            s353.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s353.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Mark Ronson")

};

            db.Songs.AddOrUpdate(s => s.SongID, s353);

            db.SaveChanges();




            Song s354 = new Song();

            s354.SongTitle = "Take Me to Church";

            s354.SongPrice = 0.99m;

            s354.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Alternative")

};

            s354.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s354.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Hozier")

};

            db.Songs.AddOrUpdate(s => s.SongID, s354);

            db.SaveChanges();




            Song s355 = new Song();

            s355.SongTitle = "These Walls";

            s355.SongPrice = 1.19m;

            s355.Genres = new List<Genre>()

{

    db.Genres.FirstOrDefault(g => g.GenreName == "Hip Hop/Rap")

};

            s355.Albums = new List<Album>()

{

    db.Albums.FirstOrDefault(b => b.AlbumTitle == "")

};

            s355.Artists = new List<Artist>()

{

    db.Artists.FirstOrDefault(a => a.ArtistName == "Kendrick Lamar")

};

            db.Songs.AddOrUpdate(s => s.SongID, s355);

            db.SaveChanges();
        }
    }
}







