using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class OrigemConfiguration : IEntityTypeConfiguration<Origem>
    {
        public OrigemConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Origem> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Procedencia).IsRequired().HasMaxLength(50);
        }
    }
}