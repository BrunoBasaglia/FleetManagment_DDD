using System.Collections.Generic;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class VeiculoService : ServiceBase<Veiculo>, IVeiculoService
    {
        private IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository) : base(veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public IEnumerable<Veiculo> Veiculos()
        {
            return _veiculoRepository.Veiculos();
        }

        public Veiculo Veiculo(int id)
        {
            return _veiculoRepository.Veiculo(id);
        }
    }
}
