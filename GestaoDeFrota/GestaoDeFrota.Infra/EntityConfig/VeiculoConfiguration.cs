using GestaoDeFrota.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeFrota.Infra.EntityConfig
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public VeiculoConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Placa).IsRequired().HasMaxLength(8);
            builder.Property(v => v.Valor).IsRequired().HasMaxLength(8);
            builder.Property(v => v.CambioId).IsRequired();
            builder.Property(v => v.CategoriaId).IsRequired();
            builder.Property(v => v.Chassi).IsRequired().HasMaxLength(17);
            builder.Property(v => v.ClasseId).IsRequired();
            builder.Property(v => v.CombustivelId).IsRequired();
            //builder.Property(v => v.FabricanteId).IsRequired();
            builder.Property(v => v.Lugares).IsRequired();
            builder.Property(v => v.ModeloId).IsRequired();
            builder.Property(v => v.MotorId).IsRequired();
            builder.Property(v => v.OrigemId).IsRequired();
            builder.Property(v => v.Portas).IsRequired();
            builder.Property(v => v.Potencia).IsRequired();
            builder.Property(v => v.Tanque).IsRequired();
            //builder.Property(v => v.Quilometragem).IsRequired();
        }
    }
}