﻿using Longhorn_Music_Team_17.Models;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Longhorn_Music_Team_17.Migrations
{
    public class SeedAppUsers
    {
        public static string email = "asdfjk";
        public static AppDbContext db = new AppDbContext();
        public static void AddAppUsers()
        {
            email = "Jacobs@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Jacobs",
                    FirstName = "Todd",
                    MiddleInitial = "L",
                    StreetAddress = "4564 Elm St.",
                    ZipCode = "77003",
                    PhoneNumber = "8176593544"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Rice@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Rice",
                    FirstName = "Eryn",
                    MiddleInitial = "M",
                    StreetAddress = "3405 Rio Grande",
                    ZipCode = "75261",
                    PhoneNumber = "2148475583"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Ingram@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Ingram",
                    FirstName = "Brad",
                    MiddleInitial = "S",
                    StreetAddress = "6548 La Posada Ct.",
                    ZipCode = "78705",
                    PhoneNumber = "5126978613"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Taylor@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Taylor",
                    FirstName = "Allison",
                    MiddleInitial = "R",
                    StreetAddress = "467 Nueces St.",
                    ZipCode = "75237",
                    PhoneNumber = "2148965621"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Martinez@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Martinez",
                    FirstName = "Gregory",
                    MiddleInitial = "R",
                    StreetAddress = "8295 Sunset Blvd.",
                    ZipCode = "78239",
                    PhoneNumber = "2105788965"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Sheffield@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Sheffield",
                    FirstName = "Martin",
                    MiddleInitial = "J",
                    StreetAddress = "3886 Avenue A",
                    ZipCode = "78736",
                    PhoneNumber = "5124678821"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "MacLeod@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "MacLeod",
                    FirstName = "Jennifer",
                    MiddleInitial = "D",
                    StreetAddress = "2504 Far West Blvd.",
                    ZipCode = "78731",
                    PhoneNumber = "5124653365"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Tanner@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Tanner",
                    FirstName = "Jeremy",
                    MiddleInitial = "S",
                    StreetAddress = "4347 Almstead",
                    ZipCode = "78761",
                    PhoneNumber = "5129457399"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Rhodes@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Rhodes",
                    FirstName = "Megan",
                    MiddleInitial = "C",
                    StreetAddress = "4587 Enfield Rd.",
                    ZipCode = "78293",
                    PhoneNumber = "2102449976"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Stuart@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Stuart",
                    FirstName = "Eric",
                    MiddleInitial = "F",
                    StreetAddress = "5576 Toro Ring",
                    ZipCode = "78279",
                    PhoneNumber = "2105344627"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Chung@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Chung",
                    FirstName = "Lisa",
                    MiddleInitial = "N",
                    StreetAddress = "234 RR 12",
                    ZipCode = "78268",
                    PhoneNumber = "2106983548"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Swanson@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Swanson",
                    FirstName = "Leon",
                    MiddleInitial = "",
                    StreetAddress = "245 River Rd",
                    ZipCode = "78731",
                    PhoneNumber = "5124748138"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Loter@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Loter",
                    FirstName = "Wanda",
                    MiddleInitial = "K",
                    StreetAddress = "3453 RR 3235",
                    ZipCode = "78732",
                    PhoneNumber = "5124579845"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "White@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "White",
                    FirstName = "Jason",
                    MiddleInitial = "M",
                    StreetAddress = "12 Valley View",
                    ZipCode = "77045",
                    PhoneNumber = "8174955201"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Montgomery@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Montgomery",
                    FirstName = "Wilda",
                    MiddleInitial = "K",
                    StreetAddress = "210 Blanco Dr",
                    ZipCode = "77030",
                    PhoneNumber = "8178746718"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Morales@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Morales",
                    FirstName = "Hector",
                    MiddleInitial = "N",
                    StreetAddress = "4501 RR 140",
                    ZipCode = "77031",
                    PhoneNumber = "8177458615"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Rankin@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Rankin",
                    FirstName = "Mary",
                    MiddleInitial = "T",
                    StreetAddress = "340 Second St",
                    ZipCode = "78703",
                    PhoneNumber = "5122926966"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Walker@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Walker",
                    FirstName = "Larry",
                    MiddleInitial = "G",
                    StreetAddress = "9 Bison Circle",
                    ZipCode = "75238",
                    PhoneNumber = "2143125897"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Chang@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Manager";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Chang",
                    FirstName = "George",
                    MiddleInitial = "M",
                    StreetAddress = "9003 Joshua St",
                    ZipCode = "78260",
                    PhoneNumber = "2103450925"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }
            email = "Gonzalez@longhornsmusic.com";
            if (!(db.Users.Any(u => u.UserName == email)))
            {
                UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));
                AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));
                string roleName = "Employee";
                if (roleManager.RoleExists(roleName) == false) { roleManager.Create(new AppRole(roleName)); }
                var userToInsert = new AppUser()
                {
                    UserName = email,
                    Email = email,
                    LastName = "Gonzalez",
                    FirstName = "Gwen",
                    MiddleInitial = "J",
                    StreetAddress = "103 Manor Rd",
                    ZipCode = "75260",
                    PhoneNumber = "2142345566"
                };
                AppUser userToAdd = userManager.FindByName(email);
                if (userToAdd == null) { userManager.Create(userToInsert, "BU9563"); userToAdd = userManager.FindByName(email); }
                if (userManager.IsInRole(userToAdd.Id, roleName) == false) { userManager.AddToRole(userToAdd.Id, roleName); }
                db.SaveChanges();
            }



        }
    }
}