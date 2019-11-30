using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class CombustivelRepository : RepositoryBase<Combustivel>, ICombustivelRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public CombustivelRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
