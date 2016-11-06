using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MIS333KProjectPractice.Models;

namespace MIS333KProjectPractice.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("MyDBConnection") { }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<MIS333KProjectPractice.Models.ViewModel> ViewModels { get; set; }
    }
}