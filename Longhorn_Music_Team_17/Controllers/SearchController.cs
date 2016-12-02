using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.Models;
using Longhorn_Music_Team_17.ViewModels;

using System.Data.Entity;

namespace Longhorn_Music_Team_17.Controllers
{
    public enum OrderType { Rating, Title, Artist }
    public enum OrderTypeArtists { Rating, Artist }
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
            string SearchAlbum, List<int?> SelectedGenres, OrderType? SelectedOrderType, SortOrder? SelectedSortOrder,
            string SelectedRating, ABRating? RatingSort, OrderTypeArtists? SelectedOrderTypeArtists, Song @song, Artist @artist, Album @album)
        {

            ViewBag.GenreList = GetAllGenres();
            if (SelectedGenres != null)
            {
                ViewBag.trueGenres = SelectedGenres;
            }
            //search for songs
            if (btn1.Equals("Songs"))
            {
                var query = from s in db.Songs select s;
                List<Song> SongResults = new List<Song>();
                // search for song title (song-specific)
                if (SearchSong != null && SearchSong != "")
                {
                    query = query.Where(s => s.SongTitle.Contains(SearchSong));
                }
                // search by artist name
                if (SearchArtist != null && SearchArtist != "")
                {
                    query = from s in query from a in s.Artists where a.ArtistName.Contains(SearchArtist) select s;
                }
                //search by album title
                if (SearchAlbum != null && SearchAlbum != "")
                {
                    query = from s in query from a in s.Albums where a.AlbumTitle.Contains(SearchAlbum) select s;
                }
                // search by genres
                if (SelectedGenres != null)
                {
                    var query3 = Enumerable.Empty <Song> ().AsQueryable();
                    foreach (int i in SelectedGenres)
                    {
                        var query2 = from s in query
                                     from g in s.Genres
                                     where g.GenreID.Equals(i)
                                     select s;
                        query3 = query2.Union(query3);
                    }
                    query = query.Intersect(query3);
                }
                
               
                // order by search parameters
                if (SelectedOrderType == null)
                {
                    
                }
                else
                {
                    //order by song title
                    if (SelectedOrderType == OrderType.Title)
                    {
                        if (SelectedSortOrder == SortOrder.Descending)
                        {
                            query = query.OrderByDescending(s => s.SongTitle);
                        }
                        else
                        {
                            query = query.OrderBy(s => s.SongTitle);
                        }
                       
                    }
                    // order by artist name

                    else if (SelectedOrderType == OrderType.Artist)
                    {
                        if (SelectedSortOrder == SortOrder.Descending)
                        {
                            query = from s in query from ar in s.Artists orderby ar.ArtistName descending select s;
                        }
                        else
                        {
                            query = from s in query from ar in s.Artists orderby ar.ArtistName select s;
                        }
                       
                    }
                }
                SongResults = query.ToList();
                if (SelectedRating != null)
                {
                    int rate = Int32.Parse(SelectedRating);

                    List<Song> songsList = new List<Song>();
                    if (RatingSort == ABRating.Above)
                    {
                        query = query.Where(s => s.Ratings.Count() > 0);
                        foreach (Song s in query)
                        {
                            if(s.Ratings.ToList().Average(x => x.RatingScore) >= rate)
                            {
                                songsList.Add(s);
                            }                             
                        }
                        SongResults = songsList;
                    }

                    else if (RatingSort == ABRating.Below)
                    {
                        foreach (Song s in query)
                        {
                            if(s.Ratings.Count() == 0)
                            {
                                songsList.Add(s);
                            }
                            else if (s.Ratings.ToList().Average(x => x.RatingScore) <= rate)
                            {
                                songsList.Add(s);
                            }
                        }
                        SongResults = songsList;
                    }
                }
              

                if(SelectedOrderType == OrderType.Rating)
                {
                    List<ItemRatingVM> itemRatings = new List<ItemRatingVM>();
                    foreach (Song s in SongResults)
                    {
                        if (s.Ratings.ToList().Count() == 0)
                        {
                            ItemRatingVM tmpVM = new ItemRatingVM
                            {
                                song = s,
                                rating = 0.0,
                            };
                            itemRatings.Add(tmpVM);                           
                        }
                        else
                        {
                            ItemRatingVM tmpVM = new ItemRatingVM
                            {
                                song = s,
                                rating = s.Ratings.ToList().Average(x => x.RatingScore),
                            };
                            itemRatings.Add(tmpVM);
                        }                 
                    }
                 
                    if (SelectedSortOrder == SortOrder.Descending)
                    {
                        itemRatings = itemRatings.OrderByDescending(o => o.rating).ToList();
                        SongResults = itemRatings.Select(o => o.song).ToList();
                    }
                    else
                    {
                        itemRatings = itemRatings.OrderBy(o => o.rating).ToList();
                        SongResults = itemRatings.Select(o => o.song).ToList();
                    }        
                }
                ViewBag.numResults = SongResults.Count();
                return View("SongSearch", SongResults);
            }
            


            // search artists 
            else if (btn1.Equals("Artists"))
            {
                List<Artist> ArtistResults = new List<Artist>();
                var query = from ar in db.Artists select ar;
                if (SearchArtist != null && SearchArtist != "")
                {
                    query = query.Where(ar => ar.ArtistName.Contains(SearchArtist));
                }
                // search by genres
                if (SelectedGenres != null)
                {
                    var query3 = Enumerable.Empty <Artist> ().AsQueryable();
                    foreach (int i in SelectedGenres)
                    {
                        var query2 = from a in query
                                     from g in a.Genres
                                     where g.GenreID.Equals(i)
                                     select a;
                        query3 = query2.Union(query3);
                    }
                    query = query.Intersect(query3);
                }

                // search by rating

                //order by
                if (SelectedOrderTypeArtists != null)
                {
                    //order by artist name
                    if (SelectedOrderTypeArtists == OrderTypeArtists.Artist)
                    {
                        if (SelectedSortOrder == SortOrder.Descending)
                        {
                            query = query.OrderByDescending(a => a.ArtistName);
                        }
                        else
                        {
                            query = query.OrderBy(a => a.ArtistName);
                        }
                    }
                 }
                ArtistResults = query.ToList();
                if (SelectedRating != null)
                {
                    int rate = Int32.Parse(SelectedRating);

                    List<Artist> artistList = new List<Artist>();
                    if (RatingSort == ABRating.Above)
                    {
                        query = query.Where(s => s.Ratings.Count() > 0);
                        foreach (Artist s in query)
                        {
                            if (s.Ratings.ToList().Average(x => x.RatingScore) >= rate)
                            {
                                artistList.Add(s);
                            }
                        }
                        ArtistResults = artistList;
                    }

                    else if (RatingSort == ABRating.Below)
                    {
                        foreach (Artist s in query)
                        {
                            if (s.Ratings.Count() == 0)
                            {
                                artistList.Add(s);
                            }
                            else if (s.Ratings.ToList().Average(x => x.RatingScore) <= rate)
                            {
                                artistList.Add(s);
                            }
                        }
                        ArtistResults = artistList;
                    }
                }

                if (SelectedOrderTypeArtists == OrderTypeArtists.Rating)
                {
                    List<ItemRatingVM> itemRatings = new List<ItemRatingVM>();
                    foreach (Artist s in ArtistResults)
                    {
                        if (s.Ratings.ToList().Count() == 0)
                        {
                            ItemRatingVM tmpVM = new ItemRatingVM
                            {
                                artist = s,
                                rating = 0.0,
                            };
                            itemRatings.Add(tmpVM);
                        }
                        else
                        {
                            ItemRatingVM tmpVM = new ItemRatingVM
                            {
                                artist = s,
                                rating = s.Ratings.ToList().Average(x => x.RatingScore),
                            };
                            itemRatings.Add(tmpVM);
                        }
                    }

                    if (SelectedSortOrder == SortOrder.Descending)
                    {
                        itemRatings = itemRatings.OrderByDescending(o => o.rating).ToList();
                        ArtistResults = itemRatings.Select(o => o.artist).ToList();
                    }
                    else
                    {
                        itemRatings = itemRatings.OrderBy(o => o.rating).ToList();
                        ArtistResults = itemRatings.Select(o => o.artist).ToList();
                    }
                }


                ViewBag.numResults = ArtistResults.Count();
                return View("ArtistSearch", ArtistResults);
            }
            




            //search albums
            else if (btn1.Equals("Albums"))
            {
                List<Album> AlbumResults = new List<Album>();
                var query = from a in db.Albums select a;
                if (SearchAlbum != null && SearchAlbum != "")
                {
                    query = query.Where(a => a.AlbumTitle.Contains(SearchAlbum));
                }
                //search by artists
                if (SearchArtist != null && SearchArtist != "")
                {
                    query = from a in query from ar in a.Artists where ar.ArtistName.Contains(SearchArtist) select a;          
                }

                // search by genres
                if (SelectedGenres != null)
                {
                    var query3 = Enumerable.Empty<Album>().AsQueryable();
                    foreach (int i in SelectedGenres)
                    {
                        var query2 = from a in query
                                     from g in a.Genres
                                     where g.GenreID.Equals(i)
                                     select a;
                        query3 = query2.Union(query3);
                    }
                    query = query.Intersect(query3);
                }

                //search order
                //order by album title
                if (SelectedOrderType == OrderType.Title)
                {
                    if (SelectedSortOrder == SortOrder.Descending)
                    {
                        query = query.OrderByDescending(a => a.AlbumTitle);
                    }
                    else
                    {
                        query = query.OrderBy(a => a.AlbumTitle);
                    }
                }
                // order by artist
                else if (SelectedOrderType == OrderType.Artist)
                {
                    if (SelectedSortOrder == SortOrder.Descending)
                    {
                        query = from a in query from ar in a.Artists orderby ar.ArtistName descending select a;
                    }
                    else
                    {
                        query = from a in query from ar in a.Artists orderby ar.ArtistName select a;
                    }
                }
                AlbumResults = query.ToList();
                if (SelectedRating != null)
                {
                    int rate = Int32.Parse(SelectedRating);

                    List<Album> albumList = new List<Album>();
                    if (RatingSort == ABRating.Above)
                    {
                        query = query.Where(s => s.Ratings.Count() > 0);
                        foreach (Album s in query)
                        {
                            if (s.Ratings.ToList().Average(x => x.RatingScore) >= rate)
                            {
                                albumList.Add(s);
                            }
                        }
                        AlbumResults = albumList;
                    }

                    else if (RatingSort == ABRating.Below)
                    {
                        foreach (Album s in query)
                        {
                            if (s.Ratings.Count() == 0)
                            {
                                albumList.Add(s);
                            }
                            else if (s.Ratings.ToList().Average(x => x.RatingScore) <= rate)
                            {
                                albumList.Add(s);
                            }
                        }
                        AlbumResults = albumList;
                    }
                }

                if (SelectedOrderType == OrderType.Rating)
                {
                    List<ItemRatingVM> itemRatings = new List<ItemRatingVM>();
                    foreach (Album s in AlbumResults)
                    {
                        if (s.Ratings.ToList().Count() == 0)
                        {
                            ItemRatingVM tmpVM = new ItemRatingVM
                            {
                                album = s,
                                rating = 0.0,
                            };
                            itemRatings.Add(tmpVM);
                        }
                        else
                        {
                            ItemRatingVM tmpVM = new ItemRatingVM
                            {
                                album = s,
                                rating = s.Ratings.ToList().Average(x => x.RatingScore),
                            };
                            itemRatings.Add(tmpVM);
                        }
                    }

                    if (SelectedSortOrder == SortOrder.Descending)
                    {
                        itemRatings = itemRatings.OrderByDescending(o => o.rating).ToList();
                        AlbumResults = itemRatings.Select(o => o.album).ToList();
                    }
                    else
                    {
                        itemRatings = itemRatings.OrderBy(o => o.rating).ToList();
                        AlbumResults = itemRatings.Select(o => o.album).ToList();
                    }
                }




                ViewBag.numResults = AlbumResults.Count();
                return View("AlbumSearch", AlbumResults);

            }


            else
            {
                return View("Index");
            }

        }



        // populate list of genres to be displayed as checkboxes
        public Dictionary<int, string> GetAllGenres()
        {
            var query = db.Genres.OrderBy(g => g.GenreName).Select(g => new { g.GenreID, g.GenreName }).ToDictionary(x => x.GenreID, x => x.GenreName);

            var GenreList = query;
            return GenreList;
        }
    }
}