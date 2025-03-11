using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Eticaret.Data.Congigurations
{
    class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {

        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Email).HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("VARCHAR(50)").HasMaxLength(20);
            builder.Property(x => x.Message).HasColumnType("VARCHAR(500)").HasMaxLength(500);

            builder.HasData
                (
                new Contact
                {
                    Id = 1,
                    Name = "Admin",
                    Surname = "Admin",
                    Email = "admin@deneme.com"
                }
                );
        }
    }
}
