namespace GerenciamentoOficinaAutomotiva.Forms
{
    partial class CadastroCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnCadastraVeiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizaCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(12, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(311, 22);
            this.txtNome.TabIndex = 0;

            // txtCpf
            this.txtCpf.Location = new System.Drawing.Point(12, 121);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(311, 22);
            this.txtCpf.TabIndex = 1;

            // txtEndereco
            this.txtEndereco.Location = new System.Drawing.Point(12, 176);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(311, 22);
            this.txtEndereco.TabIndex = 2;

            // txtTelefone
            this.txtTelefone.Location = new System.Drawing.Point(12, 238);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(311, 22);
            this.txtTelefone.TabIndex = 3;

            // btnCadastraVeiculo
            this.btnCadastraVeiculo.Location = new System.Drawing.Point(268, 389);
            this.btnCadastraVeiculo.Name = "btnCadastraVeiculo";
            this.btnCadastraVeiculo.Size = new System.Drawing.Size(121, 31);
            this.btnCadastraVeiculo.TabIndex = 4;
            this.btnCadastraVeiculo.Text = "Cadastrar Veículo";
            this.btnCadastraVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastraVeiculo.Click += new System.EventHandler(this.btnCadastraVeiculo_Click);

            // btnFinalizaCadastro
            this.btnFinalizaCadastro.Location = new System.Drawing.Point(113, 296);
            this.btnFinalizaCadastro.Name = "btnFinalizaCadastro";
            this.btnFinalizaCadastro.Size = new System.Drawing.Size(132, 34);
            this.btnFinalizaCadastro.TabIndex = 9;
            this.btnFinalizaCadastro.Text = "Finalizar Cadastro";
            this.btnFinalizaCadastro.UseVisualStyleBackColor = true;
            this.btnFinalizaCadastro.Click += new System.EventHandler(this.btnFinalizaCadastro_Click);

            // Labels
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";

            // CadastroCliente
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizaCadastro);
            this.Controls.Add(this.btnCadastraVeiculo);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnCadastraVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizaCadastro;
    }
}
