using System;
using System.Collections.Generic;
using System.Text;
using DanceBlocks.Models;
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




    }
}
