using GerenciamentoOficinaAutomotiva.Context;
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
        private readonly OficinaContext _context;

        public FrmPrincipalBusca(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository)); ;
            InitializeComponent();
        }


        private async void botãoBusca(object sender, EventArgs e)
        {

            string nomeCliente = textBox1.Text.Trim();
            var cliente = _context.Clientes.Where(c => c.Nome.Contains(nomeCliente))
                                                                   .SingleOrDefault();


            if (cliente != null)
            {
                lblNome.Text = $"Nome: {cliente.Nome}";
                lblCpf.Text = $"CPF: {cliente.Cpf}";
                lblEndereco.Text = $"Endereço: {cliente.Endereco}";
                lblTelefone.Text = $"Telefone: {cliente.Telefone}";

                // Buscar o veículo associado ao cliente
                var veiculo = _context.Veiculos
                    .Where(v => v.ClientId == cliente.Id)
                    .SingleOrDefault();

                if (veiculo != null)
                {
                    lblVeiculo.Text = $"Veículo: {veiculo.Marca} {veiculo.Modelo} ({veiculo.Cor}, {veiculo.Placa})";
                }
                else
                {
                    lblVeiculo.Text = "Veículo: Não cadastrado";
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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
        // TODO tambem incluir o label com o ID do cliente
        private void ExibeCliente(Cliente cliente)
        {

        

                lblNome.Text = $"Nome: {cliente.Nome}";
                lblCpf.Text = $"CPF: {cliente.Cpf}";
                lblEndereco.Text = $"Endereço: {cliente.Endereco}";
                lblTelefone.Text = $"Telefone: {cliente.Telefone}";


            var veiculo = cliente.Veiculos.FirstOrDefault();
            if (cliente.Veiculos != null)
            {
                lblVeiculo.Text = $"Veículo: {veiculo.Marca} {veiculo.Modelo} ({veiculo.Cor}, {veiculo.Placa})";
            }
            else
            {
                lblVeiculo.Text = "Veículo: Não cadastrado";
            }



        }


        private void txtNomeCliente(object sender, EventArgs e)
        {



        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }
    }
}
