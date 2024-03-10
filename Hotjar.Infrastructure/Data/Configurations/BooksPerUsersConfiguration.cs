using Hotjar.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Data.Configurations
{
    public class BooksPerUsersConfiguration : IEntityTypeConfiguration<BooksPerUsers>
    {
        public void Configure(EntityTypeBuilder<BooksPerUsers> builder)
        {
            builder.ToTable("BooksPerUsers");

            builder.HasKey(e => e.Id);

            builder.HasIndex(e => new { e.BookId, e.UserId }, "IX_BooksPerUsers_Unique_Compuesto").IsUnique();
        }
    }
}
