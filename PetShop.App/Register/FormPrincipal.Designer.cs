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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPets = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoricoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovoAgendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuVendas,
            this.menuAgendamentos,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuPets,
            this.menuProdutos,
            this.menuServicos});
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(71, 20);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(122, 22);
            this.menuClientes.Text = "Clientes";
            // 
            // menuPets
            // 
            this.menuPets.Name = "menuPets";
            this.menuPets.Size = new System.Drawing.Size(122, 22);
            this.menuPets.Text = "Pets";
            // 
            // menuProdutos
            // 
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(122, 22);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuServicos
            // 
            this.menuServicos.Name = "menuServicos";
            this.menuServicos.Size = new System.Drawing.Size(122, 22);
            this.menuServicos.Text = "Serviços";
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda,
            this.menuHistoricoVendas});
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(56, 20);
            this.menuVendas.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(180, 22);
            this.menuNovaVenda.Text = "Nova Venda";
            // 
            // menuHistoricoVendas
            // 
            this.menuHistoricoVendas.Name = "menuHistoricoVendas";
            this.menuHistoricoVendas.Size = new System.Drawing.Size(180, 22);
            this.menuHistoricoVendas.Text = "Histórico de Vendas";
            // 
            // menuAgendamentos
            // 
            this.menuAgendamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoAgendamento,
            this.menuConsultarAgendamentos});
            this.menuAgendamentos.Name = "menuAgendamentos";
            this.menuAgendamentos.Size = new System.Drawing.Size(100, 20);
            this.menuAgendamentos.Text = "Agendamentos";
            // 
            // menuNovoAgendamento
            // 
            this.menuNovoAgendamento.Name = "menuNovoAgendamento";
            this.menuNovoAgendamento.Size = new System.Drawing.Size(213, 22);
            this.menuNovoAgendamento.Text = "Novo Agendamento";
            // 
            // menuConsultarAgendamentos
            // 
            this.menuConsultarAgendamentos.Name = "menuConsultarAgendamentos";
            this.menuConsultarAgendamentos.Size = new System.Drawing.Size(213, 22);
            this.menuConsultarAgendamentos.Text = "Consultar Agendamentos";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 578);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 17);
            this.lblStatus.Text = "Sistema Ativo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(895, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário: Admin";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.lblBemVindo);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 24);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(1000, 554);
            this.panelConteudo.TabIndex = 2;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo.Location = new System.Drawing.Point(300, 200);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(400, 37);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-vindo ao Sistema PetShop";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema PetShop - Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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