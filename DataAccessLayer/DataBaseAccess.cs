using System;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer
{
    public class DataBaseAccess : DbContext
    {
        public DbSet<CustomerClass> Customers { get; set; }
        public DbSet<SummaryClass> Summaries { get; set; }
        public DbSet<UnemployedClass> Unemployeds { get; set; }
        public DbSet<VacancyClass> Vacancies { get; set; }
        private string DataBasePath;

        public DataBaseAccess(string DataBasePath)
        {
            this.DataBasePath = DataBasePath;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source="+DataBasePath+";");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerClass>().ToTable("CustomerTable");
            modelBuilder.Entity<SummaryClass>().ToTable("SummaryTable");
            modelBuilder.Entity<UnemployedClass>().ToTable("UnemployedTable");
            modelBuilder.Entity<VacancyClass>().ToTable("VacancyTable");
        }
    }
}
