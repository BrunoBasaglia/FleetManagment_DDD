using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class CambioConfiguration : IEntityTypeConfiguration<Cambio>
    {
        public CambioConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Cambio> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Tipo).IsRequired().HasMaxLength(150);
        }
    }
}