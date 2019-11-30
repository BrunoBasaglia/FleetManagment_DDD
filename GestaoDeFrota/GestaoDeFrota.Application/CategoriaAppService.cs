using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        public ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService) : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
}
