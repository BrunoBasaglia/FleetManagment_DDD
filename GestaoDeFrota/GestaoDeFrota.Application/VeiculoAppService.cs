using System.Collections.Generic;
using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class VeiculoAppService : AppServiceBase<Veiculo>, IVeiculoAppService
    {

        public IVeiculoService _veiculoService;

        public VeiculoAppService(IVeiculoService veiculoService) : base(veiculoService)
        {
            _veiculoService = veiculoService;
        }

        public IEnumerable<Veiculo> Veiculos()
        {
            return _veiculoService.Veiculos();
        }

        public Veiculo Veiculo(int id)
        {
            return _veiculoService.Veiculo(id);
        }

    }
}
