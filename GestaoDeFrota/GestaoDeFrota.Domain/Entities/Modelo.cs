﻿using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Modelo : EntityBase
    {
        public string Nome { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }
        public virtual int FabricanteId { get; set; }
        public virtual Fabricante Fabricante { get; private set; }

        public Modelo(int id, string nome, int fabricanteId)
        {
            SetProperties(id, nome, fabricanteId);
            ValidateValues(nome);
        }

        public void Update(int id, string nome, int fabricanteId)
        {
            SetProperties(id, nome, fabricanteId);
            ValidateValues(nome);
        }

        public void SetProperties(int id, string nome, int fabricanteId)
        {
            Id = id;
            Nome = nome;
            FabricanteId = fabricanteId;
        }

        private static void ValidateValues(string nome)
        {
            DomainException.When(string.IsNullOrEmpty(nome), "O campo modelo é obrigatório");
        }
    }
}
