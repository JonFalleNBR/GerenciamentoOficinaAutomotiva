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

namespace GerenciamentoOficinaAutomotiva.Forms
{
    public partial class CadastroCliente : Form
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly List<Veiculo> _veiculo = new List<Veiculo>();
        private int _clientId;

        public CadastroCliente(IClienteRepository clienteRepository)
        {

            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
            InitializeComponent();
        }


        public async void btnFinalizaCadastro_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Endereco = txtEndereco.Text,
                    Telefone = txtTelefone.Text,
                   
                };

                await _clienteRepository.AddClienteAsync(cliente);
                _clientId = cliente.Id;

                MessageBox.Show("Cliente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaStatusCadastro();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos e adicione pelo menos um Veículo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

   
        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {

            if(_clientId == 0)
            {
                MessageBox.Show("Cadastro um cliente primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using  (var frmVeiculo = new FrmCadastroVeiculos_(_clientId))
            {
                if(frmVeiculo.ShowDialog() == DialogResult.OK)
                {
                  MessageBox.Show("VeiculoCadastrado Com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private bool VerificaCampos()
        {
            return !string.IsNullOrEmpty(txtNome.Text) &&
                   !string.IsNullOrEmpty(txtCpf.Text) &&
                   !string.IsNullOrEmpty(txtEndereco.Text) &&
                   !string.IsNullOrEmpty(txtTelefone.Text);

        }

        private void AtualizaStatusCadastro()
        {
            btnFinalizaCadastro.Enabled = _clientId > 0;
        }

    }
}
