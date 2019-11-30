using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Tipo).IsRequired().HasMaxLength(150);
        }
    }
}