using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<ApplyForJob> ApplyForJobs { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Insert Category data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Software Development", Description = "Software development related jobs" },
                new Category { Id = 2, Name = "UI/UX Design", Description = "UI/UX design related jobs" },
                new Category { Id = 3, Name = "Software Testing", Description = "Software Testing  related jobs" }

            );

            //Insert Job data
            modelBuilder.Entity<Job>().HasData(
                new Job { Id = 1, Name = "Software Engineer", Description = "Develop software applications", CategoryId = 1, Type = "Full Time", Position = "Assiut" },
                new Job { Id = 2, Name = "UI Designer", Description = "Design user interfaces", CategoryId = 2, Type = "part time", Position = "Sohage" }
            );

            base.OnModelCreating(modelBuilder);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.
        //   UseSqlServer("Data Source=.;Initial Catalog=ProjectMVC;Integrated Security=True;Trust Server Certificate = False;Encrypt = False;");
        //}




    }
}
