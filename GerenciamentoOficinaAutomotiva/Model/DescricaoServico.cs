using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoOficinaAutomotiva.Model
{
    internal class DescricaoServico
    {
        public int Id { get; set; } // Propriedade chave primária
        public int ClientId { get; set; }

        public Cliente Cliente { get; set; }

        public int veiculoId { get; set; }

        public Veiculo    Veiculo { get; set; }

        public string TipoServico { get; set; }

        public string DescricaoDetalhada { get; set;}

    }
}
