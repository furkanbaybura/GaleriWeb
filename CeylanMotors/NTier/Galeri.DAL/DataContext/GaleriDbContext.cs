﻿using Galeri.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.DataContext
{
    public class GaleriDbContext :IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public GaleriDbContext(DbContextOptions<GaleriDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Yakinda> Yakindas { get; set; }
        public DbSet<CategoryImage> CategoryImages { get; set; }
        public DbSet<Guest> Guests { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string admin = "ceylanmotors3";
            string mail = admin + "@gmail.com";
            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>()
                   .HasData(new AppUser{
                   Id=1,
                   Name= admin,
                   Surname= admin,
                   UserName= admin,
                   NormalizedUserName = admin.ToUpper(),
                   Email= mail,
                   NormalizedEmail = mail.ToUpper(),
                   Birthdate = new DateOnly(2000,1,1),
                   Gender = Common.Gender.None,
                   EmailConfirmed = true,
                   PhoneNumberConfirmed = true,
                   PhoneNumber = "-",
                   PasswordHash = hasher.HashPassword(null,"Ceylan-0303")
                   });
            //admin role add

            builder.Entity <IdentityRole<int>>()
                          .HasData(new IdentityRole<int>
                          {
                              Id = 1,
                              Name = admin,
                              NormalizedName = admin.ToUpper()
                          });
            //user to roll add
            builder.Entity<IdentityUserRole<int>>()
                   .HasData(new IdentityUserRole<int>
                   {
                       UserId=1,
                       RoleId=1

                   });
                   
        }
    }
}
