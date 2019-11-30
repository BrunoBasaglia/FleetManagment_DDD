using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class ImagemConfiguration : IEntityTypeConfiguration<Imagem>
    {
        public ImagemConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Diretorio).HasMaxLength(150);
            builder.Property(i => i.Extensao).HasMaxLength(10);
            builder.Property(i => i.Arquivo).HasMaxLength(50);
        }
    }
}