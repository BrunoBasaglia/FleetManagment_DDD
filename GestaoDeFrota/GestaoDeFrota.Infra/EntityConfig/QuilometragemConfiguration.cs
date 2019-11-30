using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class QuilometragemConfiguration : IEntityTypeConfiguration<Quilometragem>
    {
        public QuilometragemConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Quilometragem> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Anterior).IsRequired().HasMaxLength(6);
            builder.Property(q => q.Atual).IsRequired().HasMaxLength(6);
            //builder.Property(q => q.VeiculoId).IsRequired();
        }
    }
}