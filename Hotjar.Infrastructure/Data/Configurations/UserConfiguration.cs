using Hotjar.Core.Entidades;
using Hotjar.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(e => e.Id);

            builder.HasIndex(u => u.UserName)
               .IsUnique(true);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasMany(x => x.Books)
                .WithMany(x => x.Users)
                .UsingEntity<BooksPerUsers>(
                x => x.HasOne(x => x.Book)
                .WithMany()
                .HasForeignKey(x => x.BookId)
            );
        }
    }
}
