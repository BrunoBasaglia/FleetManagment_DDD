using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class ImagemService : ServiceBase<Imagem>, IImagemService
    {
        private IImagemRepository _imagemRepository;

        public ImagemService(IImagemRepository imagemRepository) : base(imagemRepository)
        {
            _imagemRepository = imagemRepository;
        }
    }
}
