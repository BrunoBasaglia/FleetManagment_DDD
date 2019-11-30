using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class ModeloService : ServiceBase<Modelo>, IModeloService
    {
        private IModeloRepository _modeloRepository;

        public ModeloService(IModeloRepository modeloRepository) : base(modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }
    }
}
