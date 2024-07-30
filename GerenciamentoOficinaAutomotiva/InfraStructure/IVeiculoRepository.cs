using GerenciamentoOficinaAutomotiva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoOficinaAutomotiva.Repository
{
    internal interface IVeiculoRepository
    {
        Task<IEnumerable<Veiculo>> GetAllVeiculosAsync();
        Task<Veiculo> GetVeiculoByIdAsync(int id);
        Task AddVeiculoAsync(Veiculo veiculo);
        Task UpdateVeiculoAsync(Veiculo veiculo);
        Task DeleteVeiculoAsync(int id);

    }
}
