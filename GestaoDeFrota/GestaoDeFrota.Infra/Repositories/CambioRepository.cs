using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class CambioRepository : RepositoryBase<Cambio>, ICambioRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public CambioRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
