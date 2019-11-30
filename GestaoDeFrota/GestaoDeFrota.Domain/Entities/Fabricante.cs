using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Fabricante : EntityBase
    {
        public string Nome { get; set; }
        public virtual ICollection<Modelo> Modelos { get; set; }
        //public int ModeloId { get; set; }
        //public virtual Modelo Modelo { get; set; }


        public Fabricante(int id, string nome)
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
            DomainException.When(string.IsNullOrEmpty(nome), "O campo fabricante é obrigatório");
        }
    }
}
