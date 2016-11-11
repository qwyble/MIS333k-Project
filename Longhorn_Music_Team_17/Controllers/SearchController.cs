using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.DAL;
using Longhorn_Music_Team_17.Models;

using System.Data.Entity;

namespace Longhorn_Music_Team_17.Controllers
{
    public enum OrderType { Rating, Title, Artist }
    public enum OrderType2 { Rating, Artist }
    public enum SortOrder { Ascending, Descending }
    public enum ABRating { Above, Below }



    public class SearchController : Controller
    {
        AppDbContext db = new AppDbContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        //controller for basic searching from the home page
        public ActionResult Search(string btn1, string SearchString)
        {
            ViewBag.GenreList = GetAllGenres();
            if (btn1.Equals("Songs"))
            {
                List<Song> SelectedSongs = new List<Song>();

                var query = from s in db.Songs
                            select s;

                // search for song title
                if (SearchString != null && SearchString != "")
                {
                    SelectedSongs = query.Where(s => s.SongTitle.Contains(SearchString)).ToList();
                }
                else
                {
                    SelectedSongs = query.ToList();
                }
                ViewBag.numResults = SelectedSongs.Count();
                return View("SongSearch", SelectedSongs);
            }

            else if (btn1.Equals("Artists"))
            {
                List<Artist> SelectedArtists = new List<Artist>();

                var query = from a in db.Artists
                            select a;
                if (SearchString != null && SearchString != "")
                {
                    SelectedArtists = query.Where(a => a.ArtistName.Contains(SearchString)).ToList();
                }
                else
                {
                    SelectedArtists = query.ToList();
                }
                ViewBag.numResults = SelectedArtists.Count();
                return View("ArtistSearch", SelectedArtists);
            }
            else if (btn1.Equals("Albums"))
            {
                List<Album> SelectedAlbums = new List<Album>();
                var query = from a in db.Albums
                            select a;

                if (SearchString != null && SearchString != "")
                {
                    SelectedAlbums = query.Where(a => a.AlbumTitle.Contains(SearchString)).ToList();
                }
                else
                {
                    SelectedAlbums = query.ToList();
                }
                ViewBag.numResults = SelectedAlbums.Count();
                return View("AlbumSearch", SelectedAlbums);
            }
            else
            {
                return View("Index");
            }

        }


        // actionresult for 3 types of detailed searches
        public ActionResult SearchResults(string btn1, string SearchSong, string SearchArtist,
            string SearchAlbum, List<string> SelectedGenres, OrderType? SelectedOrderType, SortOrder? SelectedSortOrder,
            string SelectedRating, ABRating? RatingSort, OrderType2? SelectedOrderType2)
        {

            ViewBag.GenreList = GetAllGenres();
            if (btn1.Equals("Songs"))
            {
                var query = from s in db.Songs
                            select s;

                var query2 = from a in db.Artists
                             select a;

                // search for song title (song-specific)
                if (SearchSong != null && SearchSong != "")
                {

                    query = query.Where(s => s.SongTitle.Contains(SearchSong));
                }

                // search by artist name
                if (SearchArtist != null && SearchArtist != "")
                {
                    query2 = query2.Where(a => a.ArtistName.Contains(SearchArtist));
                }
                //search by album title
                // search by genres
                // order by search parameters
                // ascending or descending
                var SelectedSongs = query.ToList();
                ViewBag.numResults = SelectedSongs.Count();
                return View("SongSearch", SelectedSongs);
            }

            // search artists 
            else if (btn1.Equals("Artists"))
            {
                List<Artist> SelectedArtists = new List<Artist>();
                var query = from ar in db.Artists
                            select ar;
                if (SearchArtist != null && SearchArtist != "")
                {
                    query = query.Where(ar => ar.ArtistName.Contains(SearchArtist));
                }

                SelectedArtists = query.ToList();
                return View("ArtistSearch", SelectedArtists);
            }


            //search albums
            else if (btn1.Equals("Albums"))
            {
                List<Album> SelectedAlbums = new List<Album>();
                var query = from a in db.Albums
                            select a;

                if (SearchAlbum != null && SearchAlbum != "")
                {
                    query = query.Where(a => a.AlbumTitle.Contains(SearchAlbum));
                }

                SelectedAlbums = query.ToList();
                return View("AlbumSearch", SelectedAlbums);
            }

            else
            {
                return View("Index");
            }

        }



        // populate list of genres to be displayed as checkboxes
        public List<string> GetAllGenres()
        {
            var query = from g in db.Genres
                        orderby g.GenreName
                        select g.GenreName;

            List<string> GenreList = query.Distinct().ToList();
            return GenreList;
        }

        public MultiSelectList getAllGenres()
        {
            var query = from g in db.Genres
                        orderby g.GenreName
                        select g;
            List<Genre> allGenres = query.ToList();

            MultiSelectList allGenresList = new MultiSelectList(allGenres, "GenreID", "GenreName");

            return allGenresList;
        }

    }
}