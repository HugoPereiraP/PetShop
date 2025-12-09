using Microsoft.Extensions.DependencyInjection;
using PetShop.App.Forms;
using PetShop.App.Infra;
using ReaLTaiizor.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.App.Register
{
    
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //  Carregar estatísticas reais aqui
            lblQtdClientes.Text = "15"; // Exemplo
            lblValorVendas.Text = "R$ 450,00"; // Exemplo
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Fecha todos os forms filhos para mostrar o dashboard
            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }
            panelDashboard.Visible = true;
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            ShowForm<FormCadastroDono>();
        }

        private void menuPets_Click(object sender, EventArgs e)
        {
            ShowForm<FormCadastroPet>();
        }

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            try
            {
                
                panelDashboard.Visible = false;

                var novoForm = ConfigureDI.serviceProvider.GetRequiredService<TFormulario>();

                
                novoForm.MdiParent = this;
                novoForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                panelDashboard.Visible = true; 
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}