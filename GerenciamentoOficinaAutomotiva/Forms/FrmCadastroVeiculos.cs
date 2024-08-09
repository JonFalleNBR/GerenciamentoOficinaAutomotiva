using GerenciamentoOficinaAutomotiva.Model;
using System;
using System.Windows.Forms;

namespace GerenciamentoOficinaAutomotiva.Forms
{
    public partial class FrmCadastroVeiculos_ : Form
    {

        public Veiculo Veiculo { get; private set; }
        private readonly int _clientId;


        public FrmCadastroVeiculos_(int clientId)
        {
            _clientId = clientId;
            InitializeComponent();
            txtIdCliente.Text = _clientId.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                Veiculo = new Veiculo
                {

                    Placa = txtPlaca.Text,
                    Nome = txtNome.Text,
                    Cor = txtCor.Text,
                    Modelo = txtModelo.Text,
                    Marca = txtMarca.Text,
                    ClientId = _clientId
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool VerificaCampos()
        {
            return !string.IsNullOrEmpty(txtPlaca.Text) &&
                    !string.IsNullOrEmpty(txtNome.Text) &&
                    !string.IsNullOrEmpty(txtCor.Text) &&
                    !string.IsNullOrEmpty(txtModelo.Text) &&
                    !string.IsNullOrEmpty(txtMarca.Text);
        }
    }
}
