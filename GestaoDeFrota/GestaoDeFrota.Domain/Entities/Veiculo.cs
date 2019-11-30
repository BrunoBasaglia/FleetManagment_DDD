using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDeFrota.Domain.Entities
{
    public class Veiculo : EntityBase
    {
        public string Placa { get; private set; }
        public int Portas { get; private set; }
        public int Tanque { get; private set; }
        public string Chassi { get; private set; }
        public string Potencia { get; private set; }
        public int Lugares { get; private set; }
        public decimal Valor { get; private set; }
        public string Observacao { get; private set; }

        //Foreign Keys
        public int OrigemId { get; private set; }
        public int ClasseId { get; private set; }
        public int CategoriaId { get; private set; }
        public int CambioId { get; private set; }
        public int CombustivelId { get; private set; }
        public int ModeloId { get; private set; }
        public int MotorId { get; private set; }

        public double Quilometragem { get; set; }

        //Virtual Objects
        public virtual Origem Origem { get; set; }
        public virtual Classe Classe { get; private set; }
        public virtual Categoria Categoria { get; private set; }
        public virtual Cambio Cambio { get; set; }
        public virtual Combustivel Combustivel { get; private set; }
        public virtual Modelo Modelo { get; private set; }
        public virtual Motor Motor { get; private set; }
        public virtual Imagem Imagem { get; set; }
        //public Quilometragem Quilometragem { get; set; }

        [NotMapped]
        public IFormFile Img { get; set; }

        //public Veiculo(string placa, int portas, int tanque, string chassi, string potencia, int lugares, decimal valor, int origemId,
        //    int classeId, int categoriaId, int cambioId, int combustivelId, int modeloId, int motorId)
        //{
        //    SetProperties(placa, portas, tanque, chassi, potencia, lugares, valor, origemId,
        //        classeId, categoriaId, cambioId, combustivelId, modeloId, motorId);
        //    ValidateValues(placa, portas, tanque, chassi, potencia, lugares, valor, origemId,
        //        classeId, categoriaId, cambioId, combustivelId, modeloId, motorId);
        //}

        //public void Update(string placa, int portas, int tanque, string chassi, string potencia, int lugares, decimal valor, int origemId,
        //    int classeId, int categoriaId, int cambioId, int combustivelId, int modeloId, int motorId)
        //{
        //    SetProperties(placa, portas, tanque, chassi, potencia, lugares, valor, origemId,
        //        classeId, categoriaId, cambioId, combustivelId, modeloId, motorId);
        //    ValidateValues(placa, portas, tanque, chassi, potencia, lugares, valor, origemId,
        //        classeId, categoriaId, cambioId, combustivelId, modeloId, motorId);
        //}

        //public void SetProperties(string placa, int portas, int tanque, string chassi, string potencia, int lugares, decimal valor,
        //    int origemId, int classeId, int categoriaId, int cambioId, int combustivelId, int modeloId, int motorId)
        //{
        //    Placa = placa;
        //    Portas = portas;
        //    Tanque = tanque;
        //    Chassi = chassi;
        //    Potencia = potencia;
        //    Lugares = lugares;
        //    Valor = valor;
        //    OrigemId = origemId;
        //    ClasseId = classeId;
        //    CategoriaId = categoriaId;
        //    //CambioId = cambioId;
        //    CombustivelId = combustivelId;
        //    //FabricanteId = fabricanteId;
        //    ModeloId = modeloId;
        //    MotorId = MotorId;
        //}

        //private static void ValidateValues(string placa, int portas, int tanque, string chassi, string potencia, int lugares, decimal valor,
        //    int origemId, int classeId, int categoriaId, int cambioId, int combustivelId, int modeloId, int motorId)
        //{
        //    DomainException.When(string.IsNullOrEmpty(placa), "O campo placa é obrigatório!");
        //    DomainException.When(portas == 0, "O campo portas é obrigatório!");
        //    DomainException.When(tanque == 0, "O campo tanque é obrigatório!");
        //    DomainException.When(string.IsNullOrEmpty(chassi), "O campo chassi é obrigatório!");
        //    DomainException.When(string.IsNullOrEmpty(potencia), "O campo potencia é obrigatório!");
        //    DomainException.When(lugares < 1, "O campo lugares é obrigatório!");
        //    DomainException.When(valor < 0, "O campo valor é obrigatório!");
        //    DomainException.When(origemId == 0, "O campo origem é obrigatório");
        //    DomainException.When(classeId == 0, "O campo classe é obrigatório");
        //    DomainException.When(categoriaId == 0, "O campo categoria é obrigatório");
        //    DomainException.When(cambioId == 0, "O campo cambio é obrigatório");
        //    DomainException.When(combustivelId == 0, "O combustivel placa é obrigatório");
        //    //DomainException.When(fabricanteId == 0, "O campo fabricante é obrigatório");
        //    DomainException.When(modeloId == 0, "O campo modelo é obrigatório");
        //    DomainException.When(motorId == 0, "O campo motor é obrigatório");
        //}
    }
}
