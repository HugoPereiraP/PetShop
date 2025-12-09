namespace PetShop.App.Forms
{
    partial class FormCadastroPet
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboDono = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblDono = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(650, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Pet";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.numPeso);
            this.panelContent.Controls.Add(this.numIdade);
            this.panelContent.Controls.Add(this.cboSexo);
            this.panelContent.Controls.Add(this.cboDono);
            this.panelContent.Controls.Add(this.btnCancelar);
            this.panelContent.Controls.Add(this.btnSalvar);
            this.panelContent.Controls.Add(this.lblPeso);
            this.panelContent.Controls.Add(this.lblSexo);
            this.panelContent.Controls.Add(this.lblIdade);
            this.panelContent.Controls.Add(this.txtRaca);
            this.panelContent.Controls.Add(this.lblRaca);
            this.panelContent.Controls.Add(this.lblDono);
            this.panelContent.Controls.Add(this.txtEspecie);
            this.panelContent.Controls.Add(this.lblEspecie);
            this.panelContent.Controls.Add(this.txtNome);
            this.panelContent.Controls.Add(this.lblNome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(650, 440);
            this.panelContent.TabIndex = 1;
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPeso.Location = new System.Drawing.Point(220, 222);
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(160, 25);
            this.numPeso.TabIndex = 7;
            this.numPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numIdade
            // 
            this.numIdade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numIdade.Location = new System.Drawing.Point(30, 222);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(160, 25);
            this.numIdade.TabIndex = 6;
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cboSexo.Location = new System.Drawing.Point(400, 221);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(200, 25);
            this.cboSexo.TabIndex = 8;
            // 
            // cboDono
            // 
            this.cboDono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDono.FormattingEnabled = true;
            this.cboDono.Location = new System.Drawing.Point(30, 102);
            this.cboDono.Name = "cboDono";
            this.cboDono.Size = new System.Drawing.Size(570, 25);
            this.cboDono.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(490, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(360, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 40);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPeso.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPeso.Location = new System.Drawing.Point(220, 200);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(69, 19);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "Peso (Kg)";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSexo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSexo.Location = new System.Drawing.Point(400, 200);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 19);
            this.lblSexo.TabIndex = 12;
            this.lblSexo.Text = "Sexo";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdade.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIdade.Location = new System.Drawing.Point(30, 200);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(43, 19);
            this.lblIdade.TabIndex = 10;
            this.lblIdade.Text = "Idade";
            // 
            // txtRaca
            // 
            this.txtRaca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRaca.Location = new System.Drawing.Point(350, 162);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(250, 25);
            this.txtRaca.TabIndex = 5;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRaca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRaca.Location = new System.Drawing.Point(350, 140);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(39, 19);
            this.lblRaca.TabIndex = 8;
            this.lblRaca.Text = "Raça";
            // 
            // lblDono
            // 
            this.lblDono.AutoSize = true;
            this.lblDono.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDono.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDono.Location = new System.Drawing.Point(30, 80);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(126, 19);
            this.lblDono.TabIndex = 6;
            this.lblDono.Text = "Dono (Proprietário)";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEspecie.Location = new System.Drawing.Point(30, 162);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(300, 25);
            this.txtEspecie.TabIndex = 4;
            this.txtEspecie.PlaceholderText = "Ex: Cachorro, Gato...";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEspecie.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEspecie.Location = new System.Drawing.Point(30, 140);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(55, 19);
            this.lblEspecie.TabIndex = 4;
            this.lblEspecie.Text = "Espécie";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.Location = new System.Drawing.Point(30, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(570, 25);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNome.Location = new System.Drawing.Point(30, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Pet";
            // 
            // FormCadastroPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastroPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Cadastro de Pet";
            this.Load += new System.EventHandler(this.FormCadastroPet_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDono;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboDono;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.NumericUpDown numPeso;
    }
}