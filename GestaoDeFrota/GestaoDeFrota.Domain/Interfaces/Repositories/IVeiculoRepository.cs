using GestaoDeFrota.Domain.Entities;
using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Interfaces.Repositories
{
    public interface IVeiculoRepository : IRepositoryBase<Veiculo>
    {
        IEnumerable<Veiculo> Veiculos();
        Veiculo Veiculo(int id);
    }
}
