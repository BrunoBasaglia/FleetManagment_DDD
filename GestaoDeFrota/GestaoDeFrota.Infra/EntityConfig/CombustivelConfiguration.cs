using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class CombustivelConfiguration : IEntityTypeConfiguration<Combustivel>
    {
        public CombustivelConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Combustivel> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);
        }
    }
}