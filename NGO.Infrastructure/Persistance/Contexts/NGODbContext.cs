using Microsoft.EntityFrameworkCore;
using NGO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.Contexts
{
    public class NGODbContext : DbContext
    {
        public NGODbContext(DbContextOptions option) : base(option) { }

        public DbSet<Language> Languages { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<PersonalStory> PersonalStories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Library> Libraries { get; set; }

        //public DbSet<ProjectDonor> ProjectDonors { get; set; }  
        //public DbSet<ProjectImplementor> ProjectImplementors { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
