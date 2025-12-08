using Microsoft.Extensions.DependencyInjection;
using PetShop.App.Forms;
using PetShop.App.Infra;
using ReaLTaiizor.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.App.Register
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Configurações iniciais do form
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?",
                                        "Confirmar",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void menuPets_Click(object sender, EventArgs e)
        {

        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            ShowForm<FormCadastroDono>();
        }

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.serviceProvider.GetService<TFormulario>();

            if (cad is not null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

    }
}
