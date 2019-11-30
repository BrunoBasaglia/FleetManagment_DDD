using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class ClasseConfiguration : IEntityTypeConfiguration<Classe>
    {
        public ClasseConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Classificacao).IsRequired().HasMaxLength(150);
        }
    }
}