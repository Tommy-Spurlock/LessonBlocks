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
                    Id = 1,
                 Level = "Beginner"
                },

                new SkillLevel()
                {
                    Id = 2,
                    Level = "Intermediate"

                },
                 new SkillLevel()
                 {
                     Id = 3,
                     Level = "Advanced"

                 }

            );

            modelBuilder.Entity<DanceType>().HasData(
                new DanceType()
                {
                    Id = 1,
                    Name = "Rumba"
                },
               new DanceType()
               {
                   Id = 2,

                   Name = "Cha Cha"
               },
               new DanceType()
               {
                   Id = 3,

                   Name = "East Coast Swing"
               },
               new DanceType()
               {
                   Id = 4,

                   Name = "Waltz"
               },
                new DanceType()
                {
                    Id = 5,

                    Name = "Tango"
                },
                new DanceType()
                {
                    Id = 6,

                    Name = "Foxtrot"
                }
                
            );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Rhythm"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Smooth"
                }
               
            );

            modelBuilder.Entity<DanceCategory>().HasData(
                new DanceCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    DanceTypeId = 1,
                },
                new DanceCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    DanceTypeId = 2,
                },
                new DanceCategory()
                {
                    Id = 3,
                    CategoryId = 1,
                    DanceTypeId = 3,
                },
                new DanceCategory()
                {
                    Id = 4,
                    CategoryId = 2,
                    DanceTypeId = 4,
                },
                new DanceCategory()
                {
                    Id = 5,
                    CategoryId = 2,
                    DanceTypeId = 5,
                },
                new DanceCategory()
                {
                    Id = 6,
                    CategoryId = 2,
                    DanceTypeId = 6,
                }

            );

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Larry",
                    LastName = "Bird",
                    PhoneNumber = "111-111-1111",
                    Email = "larry@Bird.com",
                    Address = "123 Lucky St. Boston, MA 02101",
                    IsActive = true,
                    DanceTypeId = 1,
                    StudentStartDate = DateTime.Now,
                    SkillLevelId = 1,
                    UserId = user.Id

                },
                 new Student()
                 {
                     Id = 2,
                     FirstName = "Jenny",
                     LastName = "Gump",
                     PhoneNumber = "111-111-1112",
                     Email = "Jenny@Gump.com",
                     Address = "123 Running st. Greenbow, AL 42101",
                     IsActive = true,
                     DanceTypeId = 2,
                     StudentStartDate = DateTime.Now,
                     SkillLevelId = 2,
                     UserId = user.Id

                 },
                  new Student()
                  {
                      Id = 3,
                      FirstName = "Mark",
                      LastName = "McGwier",
                      PhoneNumber = "111-111-7111",
                      Email = "Mark@McGwier.com",
                      Address = "123 Big Mac Ave Oakland, CA 56933",
                      IsActive = true,
                      DanceTypeId = 5,
                      StudentStartDate = DateTime.Now,
                      SkillLevelId = 2,
                      UserId = user.Id

                  },
                  new Student()
                     {
                      Id = 4,
                      FirstName = "Leslie",
                      LastName = "Knope",
                      PhoneNumber = "111-111-1122",
                      Email = "Leslie@Knope.com",
                      Address = "123 City Dr. Pawnee, IN. 75101",
                      IsActive = true,
                      DanceTypeId = 3,
                      StudentStartDate = DateTime.Now,
                      SkillLevelId = 3,
                      UserId = user.Id 

                     }
            );

            modelBuilder.Entity<Step>().HasData(
                new Step()
                {
                    Id = 1,
                    Name = "Magic Step",
                    Description = "Lead: Starting with left foot, take 2 steps forward then a side step to the left and close. Follow: Starting with the right foot, take 2 steps backwards then a side step to the right and close.",
                    DanceTypeId = 6,
                    SkillLevelId = 1
                },
                new Step()
                {
                    Id = 2,
                    Name = "Promenade",
                    Description = "Lead: Look over left shoulder and rotate feet to the left keeping body in frame. Starting with left foot, take 2 horizontal steps then a side step and close while rotating back to normal position. Follow: Look over right shoulder and rotate feet to the right keeping body in frame Starting with the right foot, take 2 Horizontal steps then a side step and close while rotating to normal position.",
                    DanceTypeId = 6,
                    SkillLevelId = 2
                },
                new Step()
                {
                    Id = 3,
                    Name = "Basic Twinkle ",
                    Description = "*Box Timing* Lead: Starting with left foot, take 1 step forward, a half diagnal step w/right foot into a promenade left step. Finish with brushing right step and close box step.  Follow: Starting with the right foot, take 1 step backward, a half diagnal step w/ left foot into a promenade right step. Finish with brusing left step and close box step.",
                    DanceTypeId = 6,
                    SkillLevelId = 3
                },
                new Step()
                {
                    Id = 4,
                    Name = "Tango Basic",
                    Description = "Lead: Starting with left foot, take 3 steps forward then a side step to the right and close left foot but do not place weight on it. Follow: Starting with the right foot, take 3 steps backwards then a side step to the right and close right foot but do not place weight on it.",
                    DanceTypeId = 5,
                    SkillLevelId = 1
                }, new Step()
                {
                    Id = 5,
                    Name = "Tango Promenade",
                    Description = "Lead: Procede with Tango Basic. While closing, rotate head and toes left into promenade position.  Starting with left foot, take 2 steps in promenade, rotate partner to close then side step to the right and close left foot but do not place weight on it. Follow: Procede with Tango Basic. While closing, rotate head and toes right into promenade position. Starting with the right foot, take 2 steps in promenade, swivel to close then side step to the left and close right foot but do not place weight on it.",
                    DanceTypeId = 5,
                    SkillLevelId = 2
                }, new Step()
                {
                    Id = 6,
                    Name = "Tango Double Spin Turn",
                    Description = "Lead: Starting with left foot, take 2 steps forward. Beginning on 3rd step while rotating right take four quick rock steps. Finish with Tango Basic. Follow: Starting with the right foot, take 2 steps backwards. Beginning on 3rd step while rotating right take four quick rock steps. Finish with Tango Basic.",
                    DanceTypeId = 5,
                    SkillLevelId = 3
                },
                new Step()
                {
                    Id = 7,
                    Name = "Waltz Box",
                    Description = "Lead: Starting with left foot, take 1 steps forward. Side step to right and close left foot. Starting with right foot, take one step backwards. Side step to left and close right foot.  Follow: Starting with right foot, take 1 steps backwards. Side step to left and close right foot. Starting with Left Foot, take one step forwards. Side step to right and close left foot.",
                    DanceTypeId = 4,
                    SkillLevelId = 1
                }, new Step()
                {
                    Id = 8,
                    Name = "Waltz Promenade",
                    Description = "Lead: Rotate head and toes left into promenade positon. Starting with left foot, take 1 step in promenade. Hold for 2 counts. Step with right foot in promenade, rotate to close, and side step to left and close right foot.  Follow: Rotate head and toes right into promenade positon. Starting with right foot, take 1 step in promenade. Hold for 2 counts. Step with left foot in promenade, rotate to close and side step to right and close left foot.",
                    DanceTypeId = 4,
                    SkillLevelId = 2
                }, new Step()
                {
                    Id = 9,
                    Name = "Open Break Underarm Turn",
                    Description = "Lead: Starting with left foot, take 1 steps forward. Side step to right and close left foot. Starting with right foot; side step, open break with left foot and return weight to right foot. Side step to left foot and lift left arm. Open break to right foot as partner passes under left arm into turn. Return weight to left foot, lower left arm and side step to right. Hold for 2 counts while reconnecting with partner. Follow: Starting with right foot, take 1 steps backwards. Side step to left and close right foot. Starting with Left Foot; side step, open break with right foot and return weight to left foot. Side step to right foot and connect right hand into partners left hand. With left foot, step outside partner and on right foot spin back closed to partner.  Side step to left.",
                    DanceTypeId = 4,
                    SkillLevelId = 3
                },
                new Step()
                {
                    Id = 10,
                    Name = "Triple Time Swing Basic",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Pellentesque sit amet porttitor eget dolor morbi non arcu. Ante in nibh mauris cursus mattis. Aliquam malesuada bibendum arcu vitae elementum curabitur vitae. Tortor aliquam nulla facilisi cras fermentum.",
                    DanceTypeId = 3,
                    SkillLevelId = 1
                },
                new Step()
                {
                    Id = 11,
                    Name = "Underarm Turn",
                    Description = "Eros in cursus turpis massa tincidunt dui ut ornare lectus. Netus et malesuada fames ac turpis. Magna fermentum iaculis eu non diam phasellus. Cras tincidunt lobortis feugiat vivamus at augue. Arcu ac tortor dignissim convallis aenean et. Ipsum dolor sit amet consectetur adipiscing.",

                    DanceTypeId = 3,
                    SkillLevelId = 2
                }, new Step()
                {
                    Id = 12,
                    Name = "Walks and Kicks",
                    Description = "Eu volutpat odio facilisis mauris sit amet massa vitae tortor. Odio ut enim blandit volutpat maecenas volutpat blandit. Et malesuada fames ac turpis egestas sed tempus urna et. Molestie ac feugiat sed lectus. Eget mauris pharetra et ultrices. Justo laoreet sit amet cursus sit. Interdum consectetur libero id faucibus nisl tincidunt eget nullam. Venenatis tellus in metus vulputate eu scelerisque. Lacus suspendisse faucibus interdum posuere lorem ipsum dolor sit. Elit scelerisque mauris pellentesque pulvinar pellentesque. Morbi tincidunt augue interdum velit euismod in pellentesque. Sit amet commodo nulla facilisi nullam vehicula ipsum a arcu. Potenti nullam ac tortor vitae purus faucibus ornare suspendisse sed.",
                        DanceTypeId = 3,
                        SkillLevelId = 3
                },
                new Step()
                {
                    Id = 13,
                    Name = "Cha Cha Basic",
                    Description = "Ac orci phasellus egestas tellus. Sit amet venenatis urna cursus eget nunc scelerisque viverra mauris. Est sit amet facilisis magna etiam tempor orci eu lobortis. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at augue. In est ante in nibh. Suscipit tellus mauris a diam maecenas sed enim. Faucibus vitae aliquet nec ullamcorper sit amet risus nullam. Placerat duis ultricies lacus sed turpis tincidunt id aliquet risus. Varius sit amet mattis vulputate enim nulla aliquet. Id velit ut tortor pretium viverra.",
                    DanceTypeId = 2,
                    SkillLevelId = 1
                },
                new Step()
                {
                    Id = 14,
                    Name = "Crossover Breaks",
                    Description = "Posuere urna nec tincidunt praesent semper feugiat nibh sed pulvinar. Sem fringilla ut morbi tincidunt augue interdum velit euismod. Congue mauris rhoncus aenean vel. Eget duis at tellus at urna condimentum. In hac habitasse platea dictumst vestibulum. Quis hendrerit dolor magna eget est. At ultrices mi tempus imperdiet nulla malesuada pellentesque. Hac habitasse platea dictumst vestibulum rhoncus est pellentesque. Tempus imperdiet nulla malesuada pellentesque. Faucibus scelerisque eleifend donec pretium vulputate sapien.",
                    DanceTypeId = 2,
                    SkillLevelId = 2
                },
                new Step()
                {
                    Id = 15,
                    Name = "Backspot Turn",
                    Description = "Penatibus et magnis dis parturient montes nascetur ridiculus mus mauris. Leo integer malesuada nunc vel risus commodo viverra maecenas accumsan. Accumsan sit amet nulla facilisi morbi tempus iaculis urna. Vitae justo eget magna fermentum iaculis eu non. Ultrices gravida dictum fusce ut placerat orci. Consectetur lorem donec massa sapien faucibus et molestie. Curabitur gravida arcu ac tortor dignissim convallis aenean et. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper velit. Potenti nullam ac tortor vitae purus faucibus ornare suspendisse. Sed arcu non odio euismod lacinia. Metus aliquam eleifend mi in nulla posuere sollicitudin aliquam. Nunc sed blandit libero volutpat sed cras ornare arcu dui. At consectetur lorem donec massa sapien faucibus. Tortor pretium viverra suspendisse potenti nullam ac tortor. Blandit volutpat maecenas volutpat blandit aliquam etiam erat.",
                    DanceTypeId = 2,
                    SkillLevelId = 3
                },
                new Step()
                {
                    Id = 16,
                    Name = "Rumba Box",
                    Description = "Draught tackle crack Jennys tea cup spirits gun hail-shot starboard rope's end Shiver me timbers topmast. Scourge of the seven seas rope's end bucko hail-shot Sail ho ye knave heave down crow's nest crack Jennys tea cup. Hearties careen deadlights tack cog chantey shrouds lad strike colors lookout. Hempen halter bilge water holystone fluke red ensign Admiral of the Black bilge nipperkin black jack flogging.Draft topmast boatswain hornswaggle killick marooned haul wind cog gally ballast.Clap of thunder red ensign yawl cackle fruit lugger gun plunder Nelsons folly cutlass topsail.",
                    DanceTypeId = 1,
                    SkillLevelId = 1
                },
                new Step()
                {
                    Id = 17,
                    Name = "UnderArm Turn",
                    Description = "Penatibus et magnis dis parturient montes nascetur ridiculus mus mauris. Leo integer malesuada nunc vel risus commodo viverra maecenas accumsan. Accumsan sit amet nulla facilisi morbi tempus iaculis urna. Vitae justo eget magna fermentum iaculis eu non. Ultrices gravida dictum fusce ut placerat orci. Consectetur lorem donec massa sapien faucibus et molestie. Curabitur gravida arcu ac tortor dignissim convallis aenean et. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper velit. Potenti nullam ac tortor vitae purus faucibus ornare suspendisse. Sed arcu non odio euismod lacinia. Metus aliquam eleifend mi in nulla posuere sollicitudin aliquam. Nunc sed blandit libero volutpat sed cras ornare arcu dui. At consectetur lorem donec massa sapien faucibus. Tortor pretium viverra suspendisse potenti nullam ac tortor. Blandit volutpat maecenas volutpat blandit aliquam etiam erat.",
                    DanceTypeId = 1,
                    SkillLevelId = 2
                },
                new Step()
                {
                    Id = 18,
                    Name = "Rumba Swivels",
                    Description = "Trysail quarterdeck Blimey barkadeer furl hang the jib to go on account handsomely gangway reef. Swab hempen halter aft Spanish Main Yellow Jack doubloon sheet schooner belay cog. Lass Plate Fleet Sea Legs Jack Tar Pieces of Eight pirate yo-ho-ho careen line bilge rat. American Main topmast take a caulk ahoy fluke hulk Sink me yawl chandler jib.Black jack barque cackle fruit gangplank matey rope's end strike colors dead men tell no tales gaff capstan. Rope's end gibbet aye take a caulk parley carouser holystone stern jack pressgang. Parrel nipperkin boom wherry coffer belaying pin ahoy Admiral of the Black chase guns tack.Blimey Sea Legs reef bilge rat belay swing the lead Nelsons folly plunder avast landlubber or just lubber.Gangway driver coffer yo - ho - ho jack splice the main brace Buccaneer galleon nipperkin league.",
                    DanceTypeId = 1,
                    SkillLevelId = 3
                }
            );
            modelBuilder.Entity<Lesson>().HasData(
             new Lesson()
             {
                 Id = 1,
                 Name = "Intro",
                 Date = DateTime.Now,
                 StudentId = 1
             },

             new Lesson()
             {
                 Id = 2,
                 Name = "Intermediate",
                 Date = DateTime.Now,
                 StudentId = 2
             },
              new Lesson()
              {
                  Id = 3,
                  Name = "Advanced",
                  Date = DateTime.Now,
                  StudentId = 4
              },
               new Lesson()
               {
                   Id = 4,
                   Name = "Lesson 6",
                   Date = DateTime.Now,
                   StudentId = 3
               }
         );

            modelBuilder.Entity<LessonStep>().HasData(
             new LessonStep()
             {
                 Id = 1,
                 StepId = 1,
                 LessonId = 1
             },

             new LessonStep()
             {
                 Id = 2,
                 StepId = 4,
                 LessonId = 1
             },
              new LessonStep()
              {
                  Id = 3,
                  StepId = 7,
                  LessonId = 1
              },
               new LessonStep()
               {
                   Id = 4,
                   StepId = 10,
                   LessonId = 1
               },
               new LessonStep()
               {
                   Id = 5,
                   StepId = 2,
                   LessonId = 2
               },
               new LessonStep()
               {
                   Id = 6,
                   StepId = 5,
                   LessonId = 2
               },
               new LessonStep()
               {
                   Id = 7,
                   StepId = 8,
                   LessonId = 2
               },
               new LessonStep()
               {
                   Id = 8,
                   StepId = 11,
                   LessonId = 2
               },
               new LessonStep()
               {
                   Id = 9,
                   StepId = 3,
                   LessonId = 4
               },
               new LessonStep()
               {
                   Id = 10,
                   StepId = 6,
                   LessonId = 4
               },
               new LessonStep()
               {
                   Id = 11,
                   StepId = 9,
                   LessonId = 4
               },
               new LessonStep()
               {
                   Id = 12,
                   StepId = 12,
                   LessonId = 4
               },
               new LessonStep()
               {
                   Id = 13,
                   StepId = 8,
                   LessonId = 4
               },
               new LessonStep()
               {
                   Id = 14,
                   StepId = 5,
                   LessonId = 4
               },
               new LessonStep()
               {
                   Id = 15,
                   StepId = 11,
                   LessonId = 4
               },
               new LessonStep()
               {
                   Id = 16,
                   StepId = 2,
                   LessonId = 4
               }
         );


        } 

    }
}
