using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GestaoDeFrota.Infra.Repositories
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public VeiculoRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<Veiculo> Veiculos()
        {
            return Db.Veiculos.
                Include(v => v.Cambio).
                Include(v => v.Categoria).
                Include(v => v.Classe).
                Include(v => v.Combustivel).
                Include(v => v.Motor).
                Include(v => v.Origem).
                Include(v => v.Imagem).
                Include(m => m.Modelo).ThenInclude(f => f.Fabricante)
                .ToList();
        }

        public Veiculo Veiculo(int id)
        {
            return Db.Veiculos.
                Include(v => v.Cambio).
                Include(v => v.Categoria).
                Include(v => v.Classe).
                Include(v => v.Combustivel).
                Include(v => v.Motor).
                Include(v => v.Origem).
                Include(v => v.Imagem).
                Include(m => m.Modelo).ThenInclude(f => f.Fabricante).Where(v => v.Id == id)
                .FirstOrDefault();
        }
    }
}
