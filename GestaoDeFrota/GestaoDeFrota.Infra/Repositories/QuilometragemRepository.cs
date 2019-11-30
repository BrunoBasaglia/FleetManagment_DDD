using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class QuilometragemRepository : RepositoryBase<Quilometragem>, IQuilometragemRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public QuilometragemRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
