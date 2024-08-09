using GerenciamentoOficinaAutomotiva.Context;
using GerenciamentoOficinaAutomotiva.InfraStructure;
using GerenciamentoOficinaAutomotiva.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoOficinaAutomotiva
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var context = new OficinaContext();

            IClienteRepository clienteRepository = new ClienteRepository(context);

            Application.Run(new FrmPrincipalBusca(clienteRepository));
        }
    }
}
