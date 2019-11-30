using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public CategoriaRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
