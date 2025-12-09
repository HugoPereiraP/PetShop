using System.Drawing;
using System.Windows.Forms;

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

        #region Windows Form Designer generated code

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
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnSairLateral = new System.Windows.Forms.Button();
            this.btnAgendamentoLateral = new System.Windows.Forms.Button();
            this.btnVendaLateral = new System.Windows.Forms.Button();
            this.btnPetsLateral = new System.Windows.Forms.Button();
            this.btnClientesLateral = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblValorVendas = new System.Windows.Forms.Label();
            this.lblTituloVendas = new System.Windows.Forms.Label();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblQtdAgendamentos = new System.Windows.Forms.Label();
            this.lblTituloAgendamentos = new System.Windows.Forms.Label();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblQtdClientes = new System.Windows.Forms.Label();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuVendas,
            this.menuAgendamentos,
            this.menuRelatorios,
            this.menuSair});
            this.menuStrip.Location = new System.Drawing.Point(220, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(923, 24);
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
            this.menuCadastros.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(71, 20);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(122, 22);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuPets
            // 
            this.menuPets.Name = "menuPets";
            this.menuPets.Size = new System.Drawing.Size(122, 22);
            this.menuPets.Text = "Pets";
            this.menuPets.Click += new System.EventHandler(this.menuPets_Click);
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
            this.menuVendas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(56, 20);
            this.menuVendas.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(178, 22);
            this.menuNovaVenda.Text = "Nova Venda";
            // 
            // menuHistoricoVendas
            // 
            this.menuHistoricoVendas.Name = "menuHistoricoVendas";
            this.menuHistoricoVendas.Size = new System.Drawing.Size(178, 22);
            this.menuHistoricoVendas.Text = "Histórico de Vendas";
            // 
            // menuAgendamentos
            // 
            this.menuAgendamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoAgendamento,
            this.menuConsultarAgendamentos});
            this.menuAgendamentos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuAgendamentos.Name = "menuAgendamentos";
            this.menuAgendamentos.Size = new System.Drawing.Size(100, 20);
            this.menuAgendamentos.Text = "Agendamentos";
            // 
            // menuNovoAgendamento
            // 
            this.menuNovoAgendamento.Name = "menuNovoAgendamento";
            this.menuNovoAgendamento.Size = new System.Drawing.Size(209, 22);
            this.menuNovoAgendamento.Text = "Novo Agendamento";
            // 
            // menuConsultarAgendamentos
            // 
            this.menuConsultarAgendamentos.Name = "menuConsultarAgendamentos";
            this.menuConsultarAgendamentos.Size = new System.Drawing.Size(209, 22);
            this.menuConsultarAgendamentos.Text = "Consultar Agendamentos";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuSair
            // 
            this.menuSair.ForeColor = System.Drawing.Color.DarkRed;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.SeaGreen;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblUsuario});
            this.statusStrip.Location = new System.Drawing.Point(220, 778);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(923, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 17);
            this.lblStatus.Text = "Sistema Ativo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(827, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário: Admin";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.SeaGreen;
            this.panelMenuLateral.Controls.Add(this.btnSairLateral);
            this.panelMenuLateral.Controls.Add(this.btnAgendamentoLateral);
            this.panelMenuLateral.Controls.Add(this.btnVendaLateral);
            this.panelMenuLateral.Controls.Add(this.btnPetsLateral);
            this.panelMenuLateral.Controls.Add(this.btnClientesLateral);
            this.panelMenuLateral.Controls.Add(this.btnHome);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(220, 800);
            this.panelMenuLateral.TabIndex = 3;
            // 
            // btnSairLateral
            // 
            this.btnSairLateral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSairLateral.FlatAppearance.BorderSize = 0;
            this.btnSairLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairLateral.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSairLateral.ForeColor = System.Drawing.Color.White;
            this.btnSairLateral.Location = new System.Drawing.Point(0, 750);
            this.btnSairLateral.Name = "btnSairLateral";
            this.btnSairLateral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSairLateral.Size = new System.Drawing.Size(220, 50);
            this.btnSairLateral.TabIndex = 6;
            this.btnSairLateral.Text = "Sair do Sistema";
            this.btnSairLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairLateral.UseVisualStyleBackColor = true;
            this.btnSairLateral.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAgendamentoLateral
            // 
            this.btnAgendamentoLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendamentoLateral.FlatAppearance.BorderSize = 0;
            this.btnAgendamentoLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentoLateral.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAgendamentoLateral.ForeColor = System.Drawing.Color.White;
            this.btnAgendamentoLateral.Location = new System.Drawing.Point(0, 280);
            this.btnAgendamentoLateral.Name = "btnAgendamentoLateral";
            this.btnAgendamentoLateral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgendamentoLateral.Size = new System.Drawing.Size(220, 50);
            this.btnAgendamentoLateral.TabIndex = 5;
            this.btnAgendamentoLateral.Text = "Agendamentos";
            this.btnAgendamentoLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamentoLateral.UseVisualStyleBackColor = true;
            // 
            // btnVendaLateral
            // 
            this.btnVendaLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendaLateral.FlatAppearance.BorderSize = 0;
            this.btnVendaLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaLateral.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnVendaLateral.ForeColor = System.Drawing.Color.White;
            this.btnVendaLateral.Location = new System.Drawing.Point(0, 230);
            this.btnVendaLateral.Name = "btnVendaLateral";
            this.btnVendaLateral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVendaLateral.Size = new System.Drawing.Size(220, 50);
            this.btnVendaLateral.TabIndex = 4;
            this.btnVendaLateral.Text = "Vendas";
            this.btnVendaLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendaLateral.UseVisualStyleBackColor = true;
            // 
            // btnPetsLateral
            // 
            this.btnPetsLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPetsLateral.FlatAppearance.BorderSize = 0;
            this.btnPetsLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetsLateral.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPetsLateral.ForeColor = System.Drawing.Color.White;
            this.btnPetsLateral.Location = new System.Drawing.Point(0, 180);
            this.btnPetsLateral.Name = "btnPetsLateral";
            this.btnPetsLateral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPetsLateral.Size = new System.Drawing.Size(220, 50);
            this.btnPetsLateral.TabIndex = 3;
            this.btnPetsLateral.Text = "Pets";
            this.btnPetsLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPetsLateral.UseVisualStyleBackColor = true;
            this.btnPetsLateral.Click += new System.EventHandler(this.menuPets_Click);
            // 
            // btnClientesLateral
            // 
            this.btnClientesLateral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientesLateral.FlatAppearance.BorderSize = 0;
            this.btnClientesLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesLateral.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClientesLateral.ForeColor = System.Drawing.Color.White;
            this.btnClientesLateral.Location = new System.Drawing.Point(0, 130);
            this.btnClientesLateral.Name = "btnClientesLateral";
            this.btnClientesLateral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientesLateral.Size = new System.Drawing.Size(220, 50);
            this.btnClientesLateral.TabIndex = 2;
            this.btnClientesLateral.Text = "Clientes";
            this.btnClientesLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesLateral.UseVisualStyleBackColor = true;
            this.btnClientesLateral.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 80);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Início (Dashboard)";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(45, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(111, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "PETSHOP";
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDashboard.Controls.Add(this.lblBemVindo);
            this.panelDashboard.Controls.Add(this.panelCard3);
            this.panelDashboard.Controls.Add(this.panelCard2);
            this.panelDashboard.Controls.Add(this.panelCard1);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(220, 24);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(923, 754);
            this.panelDashboard.TabIndex = 4;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblBemVindo.Location = new System.Drawing.Point(30, 30);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(292, 45);
            this.lblBemVindo.TabIndex = 3;
            this.lblBemVindo.Text = "Visão Geral do Dia";
            // 
            // panelCard3
            // 
            this.panelCard3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelCard3.Controls.Add(this.lblValorVendas);
            this.panelCard3.Controls.Add(this.lblTituloVendas);
            this.panelCard3.Location = new System.Drawing.Point(630, 100);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.Size = new System.Drawing.Size(250, 120);
            this.panelCard3.TabIndex = 2;
            // 
            // lblValorVendas
            // 
            this.lblValorVendas.AutoSize = true;
            this.lblValorVendas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblValorVendas.ForeColor = System.Drawing.Color.White;
            this.lblValorVendas.Location = new System.Drawing.Point(15, 50);
            this.lblValorVendas.Name = "lblValorVendas";
            this.lblValorVendas.Size = new System.Drawing.Size(119, 37);
            this.lblValorVendas.TabIndex = 1;
            this.lblValorVendas.Text = "R$ 0,00";
            // 
            // lblTituloVendas
            // 
            this.lblTituloVendas.AutoSize = true;
            this.lblTituloVendas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTituloVendas.ForeColor = System.Drawing.Color.White;
            this.lblTituloVendas.Location = new System.Drawing.Point(15, 15);
            this.lblTituloVendas.Name = "lblTituloVendas";
            this.lblTituloVendas.Size = new System.Drawing.Size(99, 21);
            this.lblTituloVendas.TabIndex = 0;
            this.lblTituloVendas.Text = "Total Vendas";
            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCard2.Controls.Add(this.lblQtdAgendamentos);
            this.panelCard2.Controls.Add(this.lblTituloAgendamentos);
            this.panelCard2.Location = new System.Drawing.Point(330, 100);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Size = new System.Drawing.Size(250, 120);
            this.panelCard2.TabIndex = 1;
            // 
            // lblQtdAgendamentos
            // 
            this.lblQtdAgendamentos.AutoSize = true;
            this.lblQtdAgendamentos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblQtdAgendamentos.ForeColor = System.Drawing.Color.White;
            this.lblQtdAgendamentos.Location = new System.Drawing.Point(15, 50);
            this.lblQtdAgendamentos.Name = "lblQtdAgendamentos";
            this.lblQtdAgendamentos.Size = new System.Drawing.Size(33, 37);
            this.lblQtdAgendamentos.TabIndex = 1;
            this.lblQtdAgendamentos.Text = "0";
            // 
            // lblTituloAgendamentos
            // 
            this.lblTituloAgendamentos.AutoSize = true;
            this.lblTituloAgendamentos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTituloAgendamentos.ForeColor = System.Drawing.Color.White;
            this.lblTituloAgendamentos.Location = new System.Drawing.Point(15, 15);
            this.lblTituloAgendamentos.Name = "lblTituloAgendamentos";
            this.lblTituloAgendamentos.Size = new System.Drawing.Size(152, 21);
            this.lblTituloAgendamentos.TabIndex = 0;
            this.lblTituloAgendamentos.Text = "Agendamentos Hoje";
            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.SeaGreen;
            this.panelCard1.Controls.Add(this.lblQtdClientes);
            this.panelCard1.Controls.Add(this.lblTituloClientes);
            this.panelCard1.Location = new System.Drawing.Point(30, 100);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Size = new System.Drawing.Size(250, 120);
            this.panelCard1.TabIndex = 0;
            // 
            // lblQtdClientes
            // 
            this.lblQtdClientes.AutoSize = true;
            this.lblQtdClientes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblQtdClientes.ForeColor = System.Drawing.Color.White;
            this.lblQtdClientes.Location = new System.Drawing.Point(15, 50);
            this.lblQtdClientes.Name = "lblQtdClientes";
            this.lblQtdClientes.Size = new System.Drawing.Size(33, 37);
            this.lblQtdClientes.TabIndex = 1;
            this.lblQtdClientes.Text = "0";
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTituloClientes.ForeColor = System.Drawing.Color.White;
            this.lblTituloClientes.Location = new System.Drawing.Point(15, 15);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(107, 21);
            this.lblTituloClientes.TabIndex = 0;
            this.lblTituloClientes.Text = "Total Clientes";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 800);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelMenuLateral);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema PetShop - Tela Principal";
            this.WindowState = FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelCard3.ResumeLayout(false);
            this.panelCard3.PerformLayout();
            this.panelCard2.ResumeLayout(false);
            this.panelCard2.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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

        // Novos Elementos do Dashboard
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnSairLateral;
        private System.Windows.Forms.Button btnAgendamentoLateral;
        private System.Windows.Forms.Button btnVendaLateral;
        private System.Windows.Forms.Button btnPetsLateral;
        private System.Windows.Forms.Button btnClientesLateral;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label lblQtdClientes;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblValorVendas;
        private System.Windows.Forms.Label lblTituloVendas;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblQtdAgendamentos;
        private System.Windows.Forms.Label lblTituloAgendamentos;
        private System.Windows.Forms.Label lblBemVindo;
    }
}