using Eticaret.Core.Entities;
using Eticaret.Data.Congigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;

namespace Eticaret.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        private DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Eticaret;Trusted_Connection=True;TrustServerCertificate=true;");

            optionsBuilder.ConfigureWarnings(warnings => warnings.Throw (RelationalEventId.PendingModelChangesWarning));
            // NOT migration yaparken update-database hatasının cozumu icin
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            //modelBuilder.ApplyConfiguration(new BrandConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // çalışan dll içinden tümünü bulup otomatik dahil edicek bu yontemle yukardaki remarklardaki gibi tek tek yazmaya gerek kalmayacak NOT

            base.OnModelCreating(modelBuilder);

        }

    }
}