using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Origem : EntityBase
    {
        public string Procedencia { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Origem(int id, string procedencia)
        {
            SetProperties(id, procedencia);
            ValidateValues(procedencia);
        }

        public void Update(int id, string procedencia)
        {
            SetProperties(id, procedencia);
            ValidateValues(procedencia);
        }

        public void SetProperties(int id, string procedencia)
        {
            Id = id;
            Procedencia = procedencia;
        }

        private static void ValidateValues(string procedencia)
        {
            DomainException.When(string.IsNullOrEmpty(procedencia), "O campo procedência é obrigatório");
        }
    }
}
