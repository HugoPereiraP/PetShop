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
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelContent = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            cboCidade = new ComboBox();
            lblCidade = new Label();
            txtTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtDocumento = new MaskedTextBox();
            lblDocumento = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SeaGreen;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(770, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(23, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Dono";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnCancelar);
            panelContent.Controls.Add(btnSalvar);
            panelContent.Controls.Add(txtSenha);
            panelContent.Controls.Add(lblSenha);
            panelContent.Controls.Add(txtEndereco);
            panelContent.Controls.Add(lblEndereco);
            panelContent.Controls.Add(txtBairro);
            panelContent.Controls.Add(lblBairro);
            panelContent.Controls.Add(cboCidade);
            panelContent.Controls.Add(lblCidade);
            panelContent.Controls.Add(txtTelefone);
            panelContent.Controls.Add(lblTelefone);
            panelContent.Controls.Add(txtEmail);
            panelContent.Controls.Add(lblEmail);
            panelContent.Controls.Add(txtDocumento);
            panelContent.Controls.Add(lblDocumento);
            panelContent.Controls.Add(txtNome);
            panelContent.Controls.Add(lblNome);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 80);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(770, 587);
            panelContent.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(560, 480);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 53);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SeaGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(411, 480);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(137, 53);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(34, 376);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(251, 30);
            txtSenha.TabIndex = 8;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSenha.ForeColor = Color.DarkSlateGray;
            lblSenha.Location = new Point(34, 347);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 23);
            lblSenha.TabIndex = 14;
            lblSenha.Text = "Senha";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 10F);
            txtEndereco.Location = new Point(34, 296);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(651, 30);
            txtEndereco.TabIndex = 7;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEndereco.ForeColor = Color.DarkSlateGray;
            lblEndereco.Location = new Point(34, 267);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(81, 23);
            lblEndereco.TabIndex = 12;
            lblEndereco.Text = "Endereço";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 10F);
            txtBairro.Location = new Point(309, 216);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(377, 30);
            txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBairro.ForeColor = Color.DarkSlateGray;
            lblBairro.Location = new Point(309, 187);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(55, 23);
            lblBairro.TabIndex = 10;
            lblBairro.Text = "Bairro";
            // 
            // cboCidade
            // 
            cboCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCidade.Font = new Font("Segoe UI", 10F);
            cboCidade.FormattingEnabled = true;
            cboCidade.Location = new Point(34, 216);
            cboCidade.Margin = new Padding(3, 4, 3, 4);
            cboCidade.Name = "cboCidade";
            cboCidade.Size = new Size(251, 31);
            cboCidade.TabIndex = 5;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCidade.ForeColor = Color.DarkSlateGray;
            lblCidade.Location = new Point(34, 187);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(63, 23);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 10F);
            txtTelefone.Location = new Point(457, 136);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(228, 30);
            txtTelefone.TabIndex = 4;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.DarkSlateGray;
            lblTelefone.Location = new Point(457, 107);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(74, 23);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(34, 136);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(399, 30);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.DarkSlateGray;
            lblEmail.Location = new Point(34, 107);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 10F);
            txtDocumento.Location = new Point(457, 56);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.Mask = "000.000.000-00";
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(228, 30);
            txtDocumento.TabIndex = 2;
            txtDocumento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDocumento.ForeColor = Color.DarkSlateGray;
            lblDocumento.Location = new Point(457, 27);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(40, 23);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(34, 56);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(399, 30);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNome.ForeColor = Color.DarkSlateGray;
            lblNome.Location = new Point(34, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(137, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo";
            // 
            // FormCadastroDono
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 667);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormCadastroDono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetShop - Cadastro de Dono";
            Load += FormCadastroDono_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDocumento;
        // MUDADO PARA MASKED
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        // MUDADO PARA MASKED
        private System.Windows.Forms.MaskedTextBox txtTelefone;
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