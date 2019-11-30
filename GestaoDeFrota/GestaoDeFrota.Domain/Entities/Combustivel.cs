using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Combustivel : EntityBase
    {
        public string Nome { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Combustivel(int id, string nome)
        {
            SetProperties(id, nome);
            ValidateValues(nome);
        }

        public void Update(int id, string nome)
        {
            SetProperties(id, nome);
            ValidateValues(nome);
        }

        public void SetProperties(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        private static void ValidateValues(string nome)
        {
            DomainException.When(string.IsNullOrEmpty(nome), "O campo combustível é obrigatório");
        }
    }
}
