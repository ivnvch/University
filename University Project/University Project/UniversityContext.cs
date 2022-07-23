using Microsoft.EntityFrameworkCore;
using University_Project.university;


namespace University_Project
{
    internal class UniversityContent : DbContext
    {
        public UniversityContent()
        {
            //  Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Dean_s_Office> Dean_S_Offices { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Faculty> Faculties { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Plan> Plans { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Section> Sections { get; set; } = null!;
        public DbSet<Speciality> Specialities { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudentBook> StudentBooks { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<University> Universities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DMITRY;Database=University;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student[]
                {
                new Student { Id=1, Name="Tom", Age=19},
                new Student { Id=2, Name="Alice", Age=20},
                });

            modelBuilder.Entity<University>()
                .HasOne(p => p.City)
                .WithMany(t => t.Universities)
                .OnDelete(DeleteBehavior.Cascade);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<University>()
        //        .HasOne(p => p.City)
        //        .WithMany(t => t.Universities)
        //        .OnDelete(DeleteBehavior.Cascade);
        //}
    }
}
