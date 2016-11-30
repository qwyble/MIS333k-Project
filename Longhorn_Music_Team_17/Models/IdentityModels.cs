using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.ComponentModel.DataAnnotations;

//Change the namespace here to match your project's name
namespace Longhorn_Music_Team_17.Models
{
    // You can add profile data for the user by adding more properties to your AppUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class AppUser : IdentityUser
    {
        //TODO: Put any additional fields that you need for your users here
        //For example:
        [Required]
        public String FirstName { get; set; }
        public String MiddleInitial { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String StreetAddress { get; set; }
        [Required]
        public String ZipCode { get; set; }
        public String City { get; set; }
        public String State { get; set; }

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
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
        
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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        

        public AppDbContext()
            : base("MyDbConnection", throwIfV1Schema: false)
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
       
    }
}