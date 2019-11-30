using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Quilometragem : EntityBase
    {
        public float Atual { get; private set; }
        public float Anterior { get; private set; }
        //public int VeiculoId { get; private set; }
        //public virtual IEnumerable<Veiculo> Veiculo { get; private set; }


        public Quilometragem(float atual, float anterior)
        {
            SetProperties(atual, anterior);
            //ValidateValues(atual, anterior);
        }

        public void Update(float atual, float anterior)
        {
            SetProperties(atual, anterior);
            //ValidateValues(atual, anterior);
        }

        public void SetProperties(float atual, float anterior)
        {
            Atual = atual;
            Anterior = anterior;
        }

        //private static void ValidateValues(float atual, float anterior)
        //{
        //    DomainException.When(atual < 0, "O campo categoria é obrigatório");
        //}
    }
}
