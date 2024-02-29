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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Author)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Publisher)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasMany(x => x.Users)
                .WithMany(x => x.Books)
                .UsingEntity<BooksPerUsers>(
                x => x.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId));

        }
    }
}
