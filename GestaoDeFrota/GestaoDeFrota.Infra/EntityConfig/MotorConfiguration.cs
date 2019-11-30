using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class MotorConfiguration : IEntityTypeConfiguration<Motor>
    {
        public MotorConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Motor> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Motorizacao).IsRequired().HasMaxLength(50);
        }
    }
}