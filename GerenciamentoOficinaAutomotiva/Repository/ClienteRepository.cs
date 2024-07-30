using GerenciamentoOficinaAutomotiva.Context;
using GerenciamentoOficinaAutomotiva.Model;
using GerenciamentoOficinaAutomotiva.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoOficinaAutomotiva.InfraStructure
{
    internal class ClienteRepository : IClienteRepository

    {

        private readonly OficinaContext _context;

        public ClienteRepository(OficinaContext context)
        {
            _context = context;
        }


        public async Task AddClienteAsync(Cliente cliente)
        {
          await _context.Clientes.AddAsync(cliente);
          await _context.SaveChangesAsync();
        }

        public async Task DeleteClienteByIdAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
           _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }
    }
}
