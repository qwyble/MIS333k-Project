﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using Longhorn_Music_Team_17.ViewModels;

namespace Longhorn_Music_Team_17.Controllers
{

    public class LibraryController : Controller
    {
        AppDbContext db = new AppDbContext();
        AppUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<AppUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Search", new { btn1 = "Songs" } );
        }


        //controller for basic searching from the home page
        public ActionResult Search()
        {
            ViewBag.GenreList = GetAllGenres();
            var albumquery = formAlbumQuery().ToList();
            List<int> pAlbs = new List<int>();
            foreach (Album a in albumquery)
            {
                pAlbs.Add(a.AlbumID);
            }
            ViewBag.pAlbs = pAlbs;
            List<Song> SelectedSongs = new List<Song>();

            SelectedSongs = formQuery().ToList();

            ViewBag.numResults = SelectedSongs.Count();
            return View("SongSearch", SelectedSongs);

        }
        public IQueryable<Song> formQuery()
        {
            var query0 = from o in user.Orders
                         from od in db.OrderDetails
                         where od.OrderID == o.OrderID
                         select od;
            var query1 = from od in query0
                         select od.SongID;
            var query2 = from ad in query0
                         select ad.AlbumID;
            var query3 = from a in db.Albums
                         from ad in query2
                         where a.AlbumID == ad
                         select a;
            var query4 = from a in query3
                         from sd in a.Songs
                         select sd;
            var query5 = from s in db.Songs
                         from sdd in query1
                         where (s.SongID == sdd)
                         select s;
            var query6 = from s in db.Songs
                         from a in query3
                         from sd in a.Songs
                         where ((s.SongID == sd.SongID))
                         select s;
            var query = query5.Concat(query6).Distinct();
            return query;
        }

        public IQueryable<Album> formAlbumQuery()
        {
            var query0 = from o in user.Orders
                         from od in db.OrderDetails
                         where od.OrderID == o.OrderID
                         select od;
            var query1 = from od in query0
                         select od.AlbumID;
            var query2 = from a in db.Albums
                         from ad in query1
                         where a.AlbumID == ad
                         select a;

            /* var query1 = from od in query0
                          select od.SongID;
             var query2 = from s in db.Songs
                          from sd in query1
                          where s.SongID == sd
                          select s;
             var query3 = from ad in query0
                          select ad.AlbumID;
             var query4 = from a in db.Albums
                          from s in query2
                          from sa in s.Albums
                          from ad in query3
                          where (a.AlbumID == ad || a.AlbumID == sa.AlbumID)
                          select a;*/

            

            var query = query2.Distinct();
            return query;
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
                var query = formQuery();
                var albumquery = formAlbumQuery().ToList();
                List<int> pAlbs = new List<int>();
                foreach(Album a in albumquery)
                {
                    pAlbs.Add(a.AlbumID);
                }
                ViewBag.pAlbs = pAlbs;
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
                    var query3 = Enumerable.Empty<Song>().AsQueryable();
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
                if (SelectedOrderType != null)
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
                                if (s.Ratings.ToList().Average(x => x.RatingScore) >= rate)
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
                                if (s.Ratings.Count() == 0)
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
                if (SelectedOrderType == OrderType.Rating)
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
                var query1 = formQuery();
                var query = from a in db.Artists
                             from s in query1
                             from ar in s.Artists
                             where a.ArtistID == ar.ArtistID
                             select a;
                query = query.Distinct();

                if (SearchArtist != null && SearchArtist != "")
                {
                    query = query.Where(ar => ar.ArtistName.Contains(SearchArtist));
                }
                // search by genres
                if (SelectedGenres != null)
                {
                    var query3 = Enumerable.Empty<Artist>().AsQueryable();
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
                var query = formAlbumQuery();
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