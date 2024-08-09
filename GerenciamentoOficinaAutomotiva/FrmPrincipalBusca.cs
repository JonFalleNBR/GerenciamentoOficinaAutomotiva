using GerenciamentoOficinaAutomotiva.Model;
using GerenciamentoOficinaAutomotiva.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoOficinaAutomotiva
{
    public partial class FrmPrincipalBusca : Form
    {

        private readonly IClienteRepository _clienteRepository;


        public FrmPrincipalBusca(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository)); ;
            InitializeComponent();
        }


        private async void botãoBusca(object sender, EventArgs e)
        {

            string nomeCliente = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(nomeCliente))
            {

               
                MessageBox.Show("Por favor, insira um nome no campo de busca", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


     
            var clientes = await _clienteRepository.GetClienteByNameAsync(nomeCliente);
            
            if(clientes != null)
            {
                ExibeCliente(clientes);
            }
            else
            {
                MessageBox.Show("Usuario não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExibeCliente(Cliente cliente)
        {

         

                lblNome.Text = $"Nome: {cliente.Nome}";
                lblCpf.Text = $"CPF: {cliente.Cpf}";
                lblEndereco.Text = $"Endereço: {cliente.Endereco}";
                lblTelefone.Text = $"Telefone: {cliente.Telefone}";


       
        }


        private void txtNomeCliente(object sender, EventArgs e)
        {



        }

    }
}
