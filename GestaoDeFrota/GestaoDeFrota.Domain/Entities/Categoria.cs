using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public string Tipo { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Categoria(int id, string tipo)
        {
            SetProperties(id, tipo);
            ValidateValues(tipo);
        }

        public void Update(int id, string tipo)
        {
            SetProperties(id, tipo);
            ValidateValues(tipo);
        }

        public void SetProperties(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }

        private static void ValidateValues(string tipo)
        {
            DomainException.When(string.IsNullOrEmpty(tipo), "O campo categoria é obrigatório");
        }
    }
}
