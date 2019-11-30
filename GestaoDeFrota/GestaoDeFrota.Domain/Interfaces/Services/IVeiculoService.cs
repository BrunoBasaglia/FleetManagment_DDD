using GestaoDeFrota.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Interfaces.Services
{
    public interface IVeiculoService : IServiceBase<Veiculo>
    {
        IEnumerable<Veiculo> Veiculos();
        Veiculo Veiculo(int id);
    }
}
