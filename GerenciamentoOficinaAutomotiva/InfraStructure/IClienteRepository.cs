using GerenciamentoOficinaAutomotiva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoOficinaAutomotiva.Repository
{
    public interface IClienteRepository
    {

        Task<IEnumerable<Cliente>> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(int id);
        Task AddClienteAsync(Cliente cliente);
        Task UpdateClienteAsync(Cliente cliente);
        Task DeleteClienteByIdAsync(int id);

        Task <Cliente>GetClienteByNameAsync(string nome);
    }
}
