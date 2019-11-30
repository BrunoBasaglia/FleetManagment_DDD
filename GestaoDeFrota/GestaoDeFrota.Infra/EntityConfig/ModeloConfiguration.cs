using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class ModeloConfiguration : IEntityTypeConfiguration<Modelo>
    {
        public ModeloConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.HasKey(m => m.Id);
            //builder.Property(m => m.FabricanteId).IsRequired();
            builder.Property(m => m.Nome).IsRequired().HasMaxLength(100);
        }
    }
}