namespace PetShop.App.Forms
{
    partial class FormCadastroDono
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblCidade = new Label();
            cboCidade = new ComboBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 69);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 93);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(342, 27);
            txtNome.TabIndex = 1;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(388, 69);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(90, 20);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(388, 93);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(205, 27);
            txtDocumento.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 161);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(342, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(389, 137);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 20);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(388, 161);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(205, 27);
            txtTelefone.TabIndex = 4;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(22, 207);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(59, 20);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade:";
            // 
            // cboCidade
            // 
            cboCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCidade.FormattingEnabled = true;
            cboCidade.Location = new Point(22, 240);
            cboCidade.Margin = new Padding(3, 4, 3, 4);
            cboCidade.Name = "cboCidade";
            cboCidade.Size = new Size(228, 28);
            cboCidade.TabIndex = 5;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(274, 207);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(52, 20);
            lblBairro.TabIndex = 10;
            lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(274, 241);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(319, 27);
            txtBairro.TabIndex = 6;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(22, 272);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(74, 20);
            lblEndereco.TabIndex = 12;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(22, 296);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(571, 27);
            txtEndereco.TabIndex = 7;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(24, 327);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 14;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(23, 351);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(228, 27);
            txtSenha.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.ForestGreen;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(354, 373);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 53);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(480, 373);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 53);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCadastroDono
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 467);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(cboCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastroDono";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Cadastro de Dono";
            Load += FormCadastroDono_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}