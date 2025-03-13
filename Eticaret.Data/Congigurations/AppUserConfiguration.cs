using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Eticaret.Data.Congigurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);

            builder.Property(x => x.Surname).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasColumnType("NVARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Username).HasColumnType("NVARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.CreateDate).IsRequired();

            //builder.HasData(

            //    new AppUser
            //    {
            //        Id = 1,
            //        Name = "Admin",
            //        Surname = "Admin",
            //        IsActive = true,
            //        IsAdmin = true,
            //        Password = "123",
            //        Username = "admin",
            //        Email = "admin@testtt.com",
            //        UserGuid = new System.Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301")

            //    }
            //      );

        }
    }
}
