using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class FabricanteRepository : RepositoryBase<Fabricante>, IFabricanteRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public FabricanteRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
