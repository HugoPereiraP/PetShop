namespace PetShop.App.Register
{
    partial class FormPrincipal
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
            menuStrip = new MenuStrip();
            menuCadastros = new ToolStripMenuItem();
            menuClientes = new ToolStripMenuItem();
            menuPets = new ToolStripMenuItem();
            menuProdutos = new ToolStripMenuItem();
            menuServicos = new ToolStripMenuItem();
            menuVendas = new ToolStripMenuItem();
            menuNovaVenda = new ToolStripMenuItem();
            menuHistoricoVendas = new ToolStripMenuItem();
            menuAgendamentos = new ToolStripMenuItem();
            menuNovoAgendamento = new ToolStripMenuItem();
            menuConsultarAgendamentos = new ToolStripMenuItem();
            menuRelatorios = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            panelConteudo = new Panel();
            lblBemVindo = new Label();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuCadastros, menuVendas, menuAgendamentos, menuRelatorios, menuSair });
            menuStrip.Location = new Point(3, 85);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(1137, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            menuCadastros.DropDownItems.AddRange(new ToolStripItem[] { menuClientes, menuPets, menuProdutos, menuServicos });
            menuCadastros.Name = "menuCadastros";
            menuCadastros.Size = new Size(88, 24);
            menuCadastros.Text = "Cadastros";
            // 
            // menuClientes
            // 
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(224, 26);
            menuClientes.Text = "Clientes";
            menuClientes.Click += menuClientes_Click;
            // 
            // menuPets
            // 
            menuPets.Name = "menuPets";
            menuPets.Size = new Size(224, 26);
            menuPets.Text = "Pets";
            menuPets.Click += menuPets_Click;
            // 
            // menuProdutos
            // 
            menuProdutos.Name = "menuProdutos";
            menuProdutos.Size = new Size(224, 26);
            menuProdutos.Text = "Produtos";
            // 
            // menuServicos
            // 
            menuServicos.Name = "menuServicos";
            menuServicos.Size = new Size(224, 26);
            menuServicos.Text = "Serviços";
            // 
            // menuVendas
            // 
            menuVendas.DropDownItems.AddRange(new ToolStripItem[] { menuNovaVenda, menuHistoricoVendas });
            menuVendas.Name = "menuVendas";
            menuVendas.Size = new Size(70, 24);
            menuVendas.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            menuNovaVenda.Name = "menuNovaVenda";
            menuNovaVenda.Size = new Size(224, 26);
            menuNovaVenda.Text = "Nova Venda";
            // 
            // menuHistoricoVendas
            // 
            menuHistoricoVendas.Name = "menuHistoricoVendas";
            menuHistoricoVendas.Size = new Size(224, 26);
            menuHistoricoVendas.Text = "Histórico de Vendas";
            // 
            // menuAgendamentos
            // 
            menuAgendamentos.DropDownItems.AddRange(new ToolStripItem[] { menuNovoAgendamento, menuConsultarAgendamentos });
            menuAgendamentos.Name = "menuAgendamentos";
            menuAgendamentos.Size = new Size(124, 24);
            menuAgendamentos.Text = "Agendamentos";
            // 
            // menuNovoAgendamento
            // 
            menuNovoAgendamento.Name = "menuNovoAgendamento";
            menuNovoAgendamento.Size = new Size(259, 26);
            menuNovoAgendamento.Text = "Novo Agendamento";
            // 
            // menuConsultarAgendamentos
            // 
            menuConsultarAgendamentos.Name = "menuConsultarAgendamentos";
            menuConsultarAgendamentos.Size = new Size(259, 26);
            menuConsultarAgendamentos.Text = "Consultar Agendamentos";
            // 
            // menuRelatorios
            // 
            menuRelatorios.Name = "menuRelatorios";
            menuRelatorios.Size = new Size(90, 24);
            menuRelatorios.Text = "Relatórios";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(48, 24);
            menuSair.Text = "Sair";
            menuSair.Click += btnSair_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, lblUsuario });
            statusStrip.Location = new Point(3, 770);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1137, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 20);
            lblStatus.Text = "Sistema Ativo";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(1020, 20);
            lblUsuario.Spring = true;
            lblUsuario.Text = "Usuário: Admin";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(lblBemVindo);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(3, 115);
            panelConteudo.Margin = new Padding(3, 4, 3, 4);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(1137, 655);
            panelConteudo.TabIndex = 2;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBemVindo.Location = new Point(343, 267);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(518, 46);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem-vindo ao Sistema PetShop";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(panelConteudo);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema PetShop - Tela Principal";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuPets;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuServicos;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuHistoricoVendas;
        private System.Windows.Forms.ToolStripMenuItem menuAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem menuNovoAgendamento;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label lblBemVindo;
    }
}