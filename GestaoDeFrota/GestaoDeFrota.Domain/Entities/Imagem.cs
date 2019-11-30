using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Imagem : EntityBase
    {
        public string Arquivo { get; set; }
        public string Diretorio { get; private set; }
        public string Extensao { get; private set; }
        public virtual int VeiculoId { get; set; }
        public virtual Veiculo Veiculo { get; set; }

        public Imagem(string arquivo, string diretorio, string extensao, int veiculoId)
        {
            SetProperties(arquivo, diretorio, extensao, veiculoId);
            //ValidateValues(diretorio, extensao);
        }

        public void Update(string arquivo, string diretorio, string extensao, int veiculoId)
        {
            SetProperties(arquivo, diretorio, extensao, veiculoId);
            //ValidateValues(diretorio, extensao);
        }

        public void SetProperties(string arquivo, string diretorio, string extensao, int veiculoId)
        {
            Arquivo = arquivo;
            Diretorio = diretorio;
            Extensao = extensao;
            VeiculoId = veiculoId;
        }

        //private static void ValidateValues(string tipo)
        //{
        //    DomainException.When(string.IsNullOrEmpty(tipo), "O campo categoria é obrigatório");
        //}
    }
}
