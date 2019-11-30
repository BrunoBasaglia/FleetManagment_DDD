using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Infra.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoDeFrota.Infra.Contexto
{
    public class GestaoDeFrotasContexto : DbContext
    {

        public GestaoDeFrotasContexto(DbContextOptions<GestaoDeFrotasContexto> options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Cambio> Cambios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Combustivel> Combustiveis { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Motor> Motores { get; set; }
        public DbSet<Origem> Origens { get; set; }
        public DbSet<Quilometragem> Quilometragem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().HasOne(v => v.Cambio).WithMany(c => c.Veiculos).HasForeignKey(v => v.CambioId);
            modelBuilder.Entity<Veiculo>().HasOne(v => v.Origem).WithMany(o => o.Veiculos).HasForeignKey(c => c.OrigemId);
            modelBuilder.Entity<Veiculo>().HasOne(v => v.Classe).WithMany(o => o.Veiculos).HasForeignKey(c => c.ClasseId);
            modelBuilder.Entity<Veiculo>().HasOne(v => v.Categoria).WithMany(o => o.Veiculos).HasForeignKey(c => c.CategoriaId);
            modelBuilder.Entity<Veiculo>().HasOne(v => v.Combustivel).WithMany(o => o.Veiculos).HasForeignKey(c => c.CombustivelId);
            modelBuilder.Entity<Veiculo>().HasOne(v => v.Motor).WithMany(o => o.Veiculos).HasForeignKey(c => c.MotorId);

            modelBuilder.Entity<Veiculo>().HasOne(v => v.Modelo).WithMany(o => o.Veiculos).HasForeignKey(c => c.ModeloId);
            modelBuilder.Entity<Modelo>().HasOne(f => f.Fabricante).WithMany(m => m.Modelos).HasForeignKey(m => m.FabricanteId);
            modelBuilder.Entity<Imagem>().HasOne(v => v.Veiculo).WithOne(i => i.Imagem).HasForeignKey<Imagem>(i => i.VeiculoId);

            modelBuilder.ApplyConfiguration(new VeiculoConfiguration());
            modelBuilder.ApplyConfiguration(new CambioConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ClasseConfiguration());
            modelBuilder.ApplyConfiguration(new CombustivelConfiguration());
            modelBuilder.ApplyConfiguration(new FabricanteConfiguration());
            modelBuilder.ApplyConfiguration(new ImagemConfiguration());
            modelBuilder.ApplyConfiguration(new ModeloConfiguration());
            modelBuilder.ApplyConfiguration(new MotorConfiguration());
            modelBuilder.ApplyConfiguration(new OrigemConfiguration());
            modelBuilder.ApplyConfiguration(new QuilometragemConfiguration());

            //SEED DATA
            //CAMBIO
            modelBuilder.Entity<Cambio>().HasData(
                new Cambio(1, "Manual"),
                new Cambio(2, "Automático"),
                new Cambio(3, "Automatizado"),
                new Cambio(4, "Dualogic"),
                new Cambio(5, "CVT")
            );

            //ORIGEM
            modelBuilder.Entity<Origem>().HasData(
              new Origem(1, "Importado"),
              new Origem(2, "Nacional")
          );

            //CLASSE
            modelBuilder.Entity<Classe>().HasData(
             new Classe(1, "Utilitário"),
             new Classe(2, "Passeio"),
             new Classe(3, "Esportivo"),
             new Classe(4, "SUV"),
             new Classe(5, "Sedan"),
             new Classe(6, "Off Road"),
             new Classe(7, "Hatch"),
             new Classe(8, "Pesado"),
             new Classe(9, "Leve"),
             new Classe(10, "Médio")
         );

            //CATEGORIA
            modelBuilder.Entity<Categoria>().HasData(
             new Categoria(1, "Carro"),
             new Categoria(2, "Moto"),
             new Categoria(3, "Ônibus"),
             new Categoria(4, "Carreta"),
             new Categoria(5, "Lancha"),
             new Categoria(6, "Jet Sky"),
             new Categoria(7, "Caminhoneta"),
             new Categoria(8, "Micro-ônibus")
         );

            //COMBUSTÍVEL
            modelBuilder.Entity<Combustivel>().HasData(
             new Combustivel(1, "Álcool"),
             new Combustivel(2, "Álcool Aditivado"),
             new Combustivel(3, "Gasolina Comum"),
             new Combustivel(4, "Gasolina Aditivada"),
             new Combustivel(5, "Gasolina Pódium"),
             new Combustivel(6, "GNV"),
             new Combustivel(7, "Flex"),
             new Combustivel(8, "Diesel")
         );

            //MOTORIZAÇÃO
            modelBuilder.Entity<Motor>().HasData(
             new Motor(1, "125 Cilindradas"),
             new Motor(2, "250 Cilindradas"),
             new Motor(3, "300 Cilindardas"),
             new Motor(4, "500 Cilindardas"),
             new Motor(5, "600 Cilindardas"),
             new Motor(6, "750 Cilindardas"),
             new Motor(7, "900 Cilindardas"),
             new Motor(8, "1000 Cilindardas"),
             new Motor(9, "1300 Cilindardas"),
             new Motor(10, "1400 Cilindardas"),
             new Motor(11, "1500 Cilindardas"),
             new Motor(12, "1600 Cilindardas"),
             new Motor(13, "1700 Cilindardas"),
             new Motor(14, "2000 Cilindardas"),
             new Motor(15, "2200 Cilindardas"),
             new Motor(16, "2400 Cilindardas"),
             new Motor(17, "2800 Cilindardas"),
             new Motor(18, "3100 Cilindardas"),
             new Motor(19, "4100 Cilindardas")
         );

            //FABRICANTE
            modelBuilder.Entity<Fabricante>().HasData(
             new Fabricante(1, "Fiat"),
             new Fabricante(2, "Chevrolet"),
             new Fabricante(3, "Volkswagem"),
             new Fabricante(4, "Honda"),
             new Fabricante(5, "Toyota"),
             new Fabricante(6, "Ford")
         );

            //MODELO
            modelBuilder.Entity<Modelo>().HasData(
             new Modelo(1, "Palio", 1),
             new Modelo(2, "Argo", 1),
             new Modelo(3, "Cronos", 1),
             new Modelo(4, "Cruze", 2),
             new Modelo(5, "Captiva", 2),
             new Modelo(6, "Onix", 2),
             new Modelo(7, "Gol", 3),
             new Modelo(8, "Polo", 3),
             new Modelo(9, "Virtus", 3),
             new Modelo(10, "Fit", 4),
             new Modelo(11, "Civic", 4),
             new Modelo(12, "Etios", 5),
             new Modelo(13, "Corola", 5),
             new Modelo(14, "Focus", 6),
             new Modelo(15, "Fiesta", 6),
             new Modelo(16, "Ka", 6),
             new Modelo(17, "Edge", 6),
             new Modelo(18, "Fusion", 6),
             new Modelo(19, "Ranger", 6)
         );

        }
    }
}
