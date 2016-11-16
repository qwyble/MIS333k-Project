﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

//Change the namespace here to match your project's name
namespace Longhorn_Music_Team_17.Models
{
    // You can add profile data for the user by adding more properties to your AppUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class AppUser : IdentityUser
    {
        //TODO: Put any additional fields that you need for your users here
        //For example:
        public String FirstName { get; set; }
        public String MiddleInitial { get; set; }
        public String LastName { get; set; }
        public String StreetAddress { get; set; }
        public Int32 ZipCode { get; set; }

        //navigational properties 
        //TODO: DO THESE GO HERE?
        //public virtual List<Review> Reviews { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Card> Cards { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    //NOTE: Here is your dbContext for the entire project.  There should only be ONE DbContext per project
    //Your dbContext (AppDbContext) inherits from IdentityDbContext, which inherits from the "regular" DbContext
    //TODO: If you have an existing dbContext (it may be in your DAL folder), DELETE THE EXISTING dbContext

    public class AppDbContext : IdentityDbContext<AppUser>
    {
        //TODO: Add your dbSets here.  As an example, I've included one for products
        //Remember - the IdentityDbContext already contains a db set for Users.  If you add another one, your code will break
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //public System.Data.Entity.DbSet<Longhorn_Music_Team_17.Models.ViewModel> ViewModels { get; set; }

        public AppDbContext()
            : base("MyDbConnection", throwIfV1Schema: false)
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

       // public System.Data.Entity.DbSet<Longhorn_Music_Team_17.Models.AppUser> AppUsers { get; set; }
    }
}