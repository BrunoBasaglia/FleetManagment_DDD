using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Classe : EntityBase
    {
        public string Classificacao { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Classe(int id, string classificacao)
        {
            SetProperties(id, classificacao);
            ValidateValues(classificacao);
        }

        public void Update(int id, string classificacao)
        {
            SetProperties(id, classificacao);
            ValidateValues(classificacao);
        }

        public void SetProperties(int id, string classificacao)
        {
            Id = id;
            Classificacao = classificacao;
        }

        private static void ValidateValues(string classificacao)
        {
            DomainException.When(string.IsNullOrEmpty(classificacao), "O campo classificação é obrigatório");
        }
    }
}
