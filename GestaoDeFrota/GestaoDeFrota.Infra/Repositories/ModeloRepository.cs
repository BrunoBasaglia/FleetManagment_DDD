using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class ModeloRepository : RepositoryBase<Modelo>, IModeloRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public ModeloRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
