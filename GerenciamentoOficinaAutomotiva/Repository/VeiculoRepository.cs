using GerenciamentoOficinaAutomotiva.Context;
using GerenciamentoOficinaAutomotiva.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoOficinaAutomotiva.Repository
{
    internal class VeiculoRepository : IVeiculoRepository
    {
        private readonly OficinaContext _context;

        public VeiculoRepository(OficinaContext context)
        {
            _context = context;
        }


        public async Task AddVeiculoAsync(Veiculo veiculo)
        {
            await _context.Veiculos.AddAsync(veiculo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteVeiculoAsync(int id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);
            if(veiculo != null)
            {
                 _context.Veiculos.Remove(veiculo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Veiculo>> GetAllVeiculosAsync()
        {
            return await _context.Veiculos.Include(v => v.Cliente).ToListAsync();
        }

        public async Task<Veiculo> GetVeiculoByIdAsync(int id)
        {
            return await _context.Veiculos.Include(v => v.Cliente).FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task UpdateVeiculoAsync(Veiculo veiculo)
        {
             _context.Veiculos.Update(veiculo);
            await _context.SaveChangesAsync();
        }
    }
}
