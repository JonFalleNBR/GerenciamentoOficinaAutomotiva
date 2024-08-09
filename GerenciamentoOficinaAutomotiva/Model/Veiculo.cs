using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoOficinaAutomotiva.Model
{

   
    public class Veiculo
    {
        public int Id { get; set; }

        public string Placa { get; set; }

        public string Nome { get; set; }

        public string Cor {  get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int ClientId { get; set; }

        public Cliente Cliente { get; set; }    

    }
}
