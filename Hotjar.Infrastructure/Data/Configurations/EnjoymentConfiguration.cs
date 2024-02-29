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
    public class EnjoymentConfiguration : IEntityTypeConfiguration<EnjoymentForm>
    {
        public void Configure(EntityTypeBuilder<EnjoymentForm> builder)
        {
            builder.ToTable("EnjoymentForm");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.SatisfactionLevel)
                .IsRequired();

            builder.Property(e => e.Observations)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.MoreRelated)
                .IsRequired();

            builder.Property(e => e.ReadTheSameAuthor)
                .IsRequired();
        }
    }
}
