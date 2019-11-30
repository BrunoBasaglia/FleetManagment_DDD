using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class ImagemAppService : AppServiceBase<Imagem>, IImagemAppService
    {
        public IImagemService _imagemService;

        public ImagemAppService(IImagemService imagemService) : base(imagemService)
        {
            _imagemService = imagemService;
        }
    }
}
