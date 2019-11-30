using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class ClasseRepository : RepositoryBase<Classe>, IClasseRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public ClasseRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
