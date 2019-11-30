using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Motor : EntityBase
    {
        public string Motorizacao { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Motor(int id, string motorizacao)
        {
            SetProperties(id, motorizacao);
            ValidateValues(motorizacao);
        }

        public void Update(int id, string motorizacao)
        {
            SetProperties(id, motorizacao);
            ValidateValues(motorizacao);
        }

        public void SetProperties(int id, string motorizacao)
        {
            Id = id;
            Motorizacao = motorizacao;
        }

        private static void ValidateValues(string motorizacao)
        {
            DomainException.When(string.IsNullOrEmpty(motorizacao), "O campo motorização é obrigatório");
        }
    }
}
