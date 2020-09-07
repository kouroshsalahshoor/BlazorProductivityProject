using System;
using System.Collections.Generic;
using System.Text;
using BlazorProductivityProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorProductivityProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Belgium" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "Germany" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 4, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 5, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 6, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 7, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 8, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { Id = 9, Name = "Brazil" });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 1, Name = "Pie research" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 2, Name = "Sales" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 3, Name = "Management" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 4, Name = "Store staff" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 5, Name = "Finance" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 6, Name = "QA" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 7, Name = "IT" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 8, Name = "Cleaning" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { Id = 9, Name = "Bakery" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                FirstName = "Bethany",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),
                Latitude = 50.8503,
                Longitude = 4.3517
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                CountryId = 2,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Antwerp",
                Email = "gill@bethanyspieshop.com",
                Id = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
                Gender = Gender.Male,
                PhoneNumber = "33999909923",
                Smoker = false,
                Street = "New Street",
                Zip = "2000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24),
                Latitude = 50.8503,
                Longitude = 4.3517
            });
        }
    }
}
