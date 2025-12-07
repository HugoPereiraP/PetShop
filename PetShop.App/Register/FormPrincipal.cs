using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace PetShop.App.Register
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
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
            {
                this.Close();
            }
        }
    }
}