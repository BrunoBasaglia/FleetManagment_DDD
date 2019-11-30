using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class ImagemRepository : RepositoryBase<Imagem>, IImagemRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public ImagemRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
