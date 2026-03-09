using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Hostel> Hostels { get; set; }
    public DbSet<Mark> Marks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        // Suppress the pending model changes warning
        optionsBuilder.ConfigureWarnings(w => 
            w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User - Student relationship (One-to-One)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Student)
                .WithOne(s => s.User)
                .HasForeignKey<Student>(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Student - Hostel relationship (One-to-One)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Hostel)
                .WithOne(h => h.Student)
                .HasForeignKey<Student>(s => s.HostelId)
                .OnDelete(DeleteBehavior.SetNull);

            // Student - Mark relationship (One-to-Many)
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Marks)
                .WithOne(m => m.Student)
                .HasForeignKey(m => m.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure decimal precision
            modelBuilder.Entity<Student>()
                .Property(s => s.Subject1Marks)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student>()
                .Property(s => s.Subject2Marks)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student>()
                .Property(s => s.Subject3Marks)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student>()
                .Property(s => s.Subject4Marks)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student>()
                .Property(s => s.Subject5Marks)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Mark>()
                .Property(m => m.MarksObtained)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Mark>()
                .Property(m => m.TotalMarks)
                .HasPrecision(5, 2);

            // Add unique constraint on User Email
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Create default admin user (password: Admin@123)
            var adminUser = new User
            {
                UserId = 1,
                Email = "admin@studentmgmt.com",
                FirstName = "Admin",
                LastName = "User",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                Role = "Admin",
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };

            modelBuilder.Entity<User>().HasData(adminUser);
        }
    }
}
