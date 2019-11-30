using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class MotorRepository : RepositoryBase<Motor>, IMotorRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public MotorRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
