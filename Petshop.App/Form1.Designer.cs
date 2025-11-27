namespace Petshop.App
{
    partial class FormServico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new MaterialSkin.Controls.MaterialTextBox();
            txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            txtPreco = new MaterialSkin.Controls.MaterialTextBox();
            btnCadastrar = new MaterialSkin.Controls.MaterialButton();
            btnExcluir = new MaterialSkin.Controls.MaterialButton();
            btnAtualizar = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            btnNovo = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            mtbData = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dataGridViewList = new DataGridView();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.Hint = "Nome:";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(62, 15);
            txtNome.MaxLength = 50;
            txtNome.MouseState = MaterialSkin.MouseState.OUT;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 50);
            txtNome.TabIndex = 1;
            txtNome.Text = "";
            txtNome.TrailingIcon = null;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.Hint = "Descrição:";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(62, 73);
            txtDescricao.MaxLength = 50;
            txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricao.Multiline = false;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(670, 50);
            txtDescricao.TabIndex = 3;
            txtDescricao.Text = "";
            txtDescricao.TrailingIcon = null;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.Hint = "Preço:";
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(343, 15);
            txtPreco.MaxLength = 50;
            txtPreco.MouseState = MaterialSkin.MouseState.OUT;
            txtPreco.Multiline = false;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(204, 50);
            txtPreco.TabIndex = 5;
            txtPreco.Text = "";
            txtPreco.TrailingIcon = null;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrar.Depth = 0;
            btnCadastrar.HighEmphasis = true;
            btnCadastrar.Icon = null;
            btnCadastrar.Location = new Point(514, 227);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = Color.Empty;
            btnCadastrar.Size = new Size(106, 36);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.Location = new Point(628, 227);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAtualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAtualizar.Depth = 0;
            btnAtualizar.HighEmphasis = true;
            btnAtualizar.Icon = null;
            btnAtualizar.Location = new Point(711, 227);
            btnAtualizar.Margin = new Padding(4, 6, 4, 6);
            btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.NoAccentTextColor = Color.Empty;
            btnAtualizar.Size = new Size(99, 36);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.TextAlign = ContentAlignment.MiddleRight;
            btnAtualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAtualizar.UseAccentColor = false;
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(818, 227);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click; // <-- ADICIONADO
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.Location = new Point(897, 227);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 10;
            btnNovo.Text = "Novo";
            btnNovo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click; // <-- ADICIONADO
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnCancelar);
            materialCard1.Controls.Add(mtbData);
            materialCard1.Controls.Add(dataGridViewList);
            materialCard1.Controls.Add(txtNome);
            materialCard1.Controls.Add(btnNovo);
            materialCard1.Controls.Add(txtDescricao);
            materialCard1.Controls.Add(btnEditar);
            materialCard1.Controls.Add(txtPreco);
            materialCard1.Controls.Add(btnAtualizar);
            materialCard1.Controls.Add(btnExcluir);
            materialCard1.Controls.Add(btnCadastrar);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1027, 547);
            materialCard1.TabIndex = 11;
            // 
            // mtbData
            // 
            mtbData.AllowPromptAsInput = true;
            mtbData.AnimateReadOnly = false;
            mtbData.AsciiOnly = false;
            mtbData.BackgroundImageLayout = ImageLayout.None;
            mtbData.BeepOnError = false;
            mtbData.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbData.Depth = 0;
            mtbData.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbData.HidePromptOnLeave = false;
            mtbData.HideSelection = true;
            mtbData.Hint = "Data";
            mtbData.InsertKeyMode = InsertKeyMode.Default;
            mtbData.LeadingIcon = null;
            mtbData.Location = new Point(553, 17);
            mtbData.Mask = "00/00/0000";
            mtbData.MaxLength = 32767;
            mtbData.MouseState = MaterialSkin.MouseState.OUT;
            mtbData.Name = "mtbData";
            mtbData.PasswordChar = '\0';
            mtbData.PrefixSuffixText = null;
            mtbData.PromptChar = '_';
            mtbData.ReadOnly = false;
            mtbData.RejectInputOnFirstFailure = false;
            mtbData.ResetOnPrompt = true;
            mtbData.ResetOnSpace = true;
            mtbData.RightToLeft = RightToLeft.No;
            mtbData.SelectedText = "";
            mtbData.SelectionLength = 0;
            mtbData.SelectionStart = 0;
            mtbData.ShortcutsEnabled = true;
            mtbData.Size = new Size(179, 48);
            mtbData.SkipLiterals = true;
            mtbData.TabIndex = 16;
            mtbData.TabStop = false;
            mtbData.Text = "  /  /";
            mtbData.TextAlign = HorizontalAlignment.Left;
            mtbData.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbData.TrailingIcon = null;
            mtbData.UseSystemPasswordChar = false;
            mtbData.ValidatingType = null;
            // 
            // dataGridViewList
            // 
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(62, 272);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.RowHeadersWidth = 51;
            dataGridViewList.Size = new Size(899, 258);
            dataGridViewList.TabIndex = 12;
            // configure selection and auto columns to avoid issues if designer columns were removed
            dataGridViewList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewList.MultiSelect = false;
            dataGridViewList.AutoGenerateColumns = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(410, 227);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 642);
            Controls.Add(materialCard1);
            Name = "FormServico";
            Text = "Serviço";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialTextBox txtPreco;
        private MaterialSkin.Controls.MaterialButton btnCadastrar;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialButton btnAtualizar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnNovo;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private DataGridView dataGridViewList;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtbData;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}
