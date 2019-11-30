using GestaoDeFrota.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDeFrota.Application.Interface
{
    public interface IVeiculoAppService : IAppServiceBase<Veiculo>
    {
        IEnumerable<Veiculo> Veiculos();
        Veiculo Veiculo(int id);
    }
}
