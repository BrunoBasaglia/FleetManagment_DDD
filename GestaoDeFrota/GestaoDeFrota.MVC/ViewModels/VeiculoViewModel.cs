using GestaoDeFrota.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDeFrota.MVC.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:AAA-9999}")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int Portas { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int Tanque { get; set; }
        [MaxLength(17)]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Chassi { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Potencia { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int Lugares { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public decimal Valor { get; set; }
        [MaxLength(300)]
        public string Observacao { get; set; }
        [Required(ErrorMessage = "Campo obrigatório.")]
        public double Quilometragem { get; set; }
        public string Fabricante { get; set; }

        //FOREIGN KEYS
        [ForeignKey("OrigemId")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int OrigemId { get; set; }
        public virtual Origem Origem { get; set; }

        [ForeignKey("ClasseId")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int ClasseId { get; set; }
        public virtual Classe Classe { get; set; }

        [ForeignKey("CategoriaId")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("CambioId")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int CambioId { get; set; }
        public virtual Cambio Cambio { get; set; }

        [ForeignKey("CombustivelId")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int CombustivelId { get; set; }
        public virtual Combustivel Combustivel { get; set; }

        [ForeignKey("ModeloId")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }

        [ForeignKey("MotorId")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public int MotorId { get; set; }
        public virtual Motor Motor { get; set; }

        [ForeignKey("ImagemId")]
        public int ImagemId { get; set; }
        public virtual Imagem Imagem { get; set; }

        [NotMapped]
        public IFormFile Img { get; set; }

    }
}
