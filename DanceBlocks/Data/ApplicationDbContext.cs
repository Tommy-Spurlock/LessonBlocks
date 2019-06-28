using System;
using System.Collections.Generic;
using System.Text;
using DanceBlocks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DanceBlocks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<DanceType> DanceTypes { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<SkillLevel> SkillLevels { get; set; }

        public DbSet<Step> Steps { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<LessonStep> LessonSteps { get; set; }

        public DbSet<DanceCategory> DanceCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
         

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Admina",
                LastName = "Straytor",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<SkillLevel>().HasData(
                new SkillLevel()
                {
                 Level = "Beginner"
                },

                new SkillLevel()
                {
                    Level = "Intermediate"

                },
                 new SkillLevel()
                 {
                     Level = "Advanced"

                 }

            );

            modelBuilder.Entity<DanceType>().HasData(
                new DanceType()
                {
                    Name = "Rumba"
                },
               new DanceType()
               {
                   Name = "Cha Cha"
               },
               new DanceType()
               {
                   Name = "East Coast Swing"
               },
               new DanceType()
               {
                   Name = "Waltz"
               },
                new DanceType()
                {
                    Name = "Tango"
                },
                new DanceType()
                {
                    Name = "Foxtrot"
                },
                new DanceType()
                {
                    Name = "Hustle"
                },
                new DanceType()
                {
                    Name = "West Coast Swing"
                },
                new DanceType()
                {
                    Name = "Salsa"
                },
                new DanceType()
                {
                    Name = "Bachata"
                },
                new DanceType()
                {
                    Name = "Merengue"
                },
                new DanceType()
                {
                    Name = "Foxxy"
                },
                new DanceType()
                {
                    Name = "Kizomba"
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Name = "Rhythm"
                },
                new Category()
                {
                    Name = "Smooth"
                },
                new Category()
                {
                    Name = "Latin Nights"
                },
                new Category()
                {
                    Name = "Boogie Down"
                }
               
            );

            modelBuilder.Entity<DanceCategory>().HasData(
                new DanceCategory()
                {
                    
                    CategoryId = 1,
                    DanceTypeId = 1,
                },
                new DanceCategory()
                {

                    CategoryId = 1,
                    DanceTypeId = 2,
                },
                new DanceCategory()
                {

                    CategoryId = 1,
                    DanceTypeId = 3,
                },
                new DanceCategory()
                {

                    CategoryId = 2,
                    DanceTypeId = 4,
                },
                new DanceCategory()
                {

                    CategoryId = 2,
                    DanceTypeId = 5,
                },
                new DanceCategory()
                {

                    CategoryId = 2,
                    DanceTypeId = 6,
                },
                new DanceCategory()
                {

                    CategoryId = 3,
                    DanceTypeId = 9,
                },
                new DanceCategory()
                {

                    CategoryId = 3,
                    DanceTypeId = 10,
                },
                new DanceCategory()
                {

                    CategoryId = 3,
                    DanceTypeId = 11,
                },
                new DanceCategory()
                {

                    CategoryId = 3,
                    DanceTypeId = 13,
                }

            );

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    FirstName = "Larry",
                    LastName = "Bird",
                    PhoneNumber = "111-111-1111",
                    Email = "larry@Bird.com",
                    Address = "123 Lucky St. Boston, MA 02101",
                    IsActive = true,
                    DanceTypeId = 1,
                    StudentStartDate = DateTime.Now,
                    SkillLevelId = 1,
                    UserId = 1

                },
                 new Student()
                 {
                     FirstName = "Jenny",
                     LastName = "Gump",
                     PhoneNumber = "111-111-1112",
                     Email = "Jenny@Gump.com",
                     Address = "123 Running st. Greenbow, AL 42101",
                     IsActive = true,
                     DanceTypeId = 2,
                     StudentStartDate = DateTime.Now,
                     SkillLevelId = 2,
                     UserId = 1

                 },
                  new Student()
                  {
                      FirstName = "Mark",
                      LastName = "McGwier",
                      PhoneNumber = "111-111-7111",
                      Email = "Mark@McGwier.com",
                      Address = "123 Big Mac Ave Oakland, CA 56933",
                      IsActive = true,
                      DanceTypeId = 5,
                      StudentStartDate = DateTime.Now,
                      SkillLevelId = 2,
                      UserId = 1

                  },
                  new Student()
                     {
                      FirstName = "Leslie",
                      LastName = "Knope",
                      PhoneNumber = "111-111-1122",
                      Email = "Leslie@Knope.com",
                      Address = "123 City Dr. Pawnee, IN. 75101",
                      IsActive = true,
                      DanceTypeId = 10,
                      StudentStartDate = DateTime.Now,
                      SkillLevelId = 3,
                      UserId = 1

                     }
            );

            modelBuilder.Entity<Step>().HasData(
                new Step()
                {
                    Name = "Magic Step",
                    Description = "Lead: Starting with left foot, take 2 steps forward then a side step to the left and close. Follow: Starting with the right foot, take 2 steps backwards then a side step to the right and close.",
                    DanceTypeId = 6,
                    SkillLevelId = 1
                },
                new Step()
                {
                    Name = "Promenade",
                    Description = "Lead: Look over left shoulder and rotate feet to the left keeping body in frame. Starting with left foot, take 2 horizontal steps then a side step and close while rotating back to normal position. Follow: Look over right shoulder and rotate feet to the right keeping body in frame Starting with the right foot, take 2 Horizontal steps then a side step and close while rotating to normal position.",
                    DanceTypeId = 6,
                    SkillLevelId = 2
                },
                new Step()
                {
                    Name = "Basic Twinkle ",
                    Description = "Lead: Starting with left foot, take 2 steps forward then a side step to the left and close. Follow: Starting with the right foot, take 2 steps backwards then a side step to the right and close.",
                    DanceTypeId = 6,
                    SkillLevelId = 3
                }
            );
        } 

    }
}
