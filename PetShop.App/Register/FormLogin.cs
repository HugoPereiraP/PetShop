using ReaLTaiizor.Forms;
using Microsoft.Extensions.DependencyInjection;
using PetShop.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace PetShop.App.Register
{
    public partial class FormLogin : MaterialForm
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IServiceProvider _serviceProvider;

        public FormLogin(IUsuarioService usuarioService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _serviceProvider = serviceProvider;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = _usuarioService.ValidarLogin(email, senha);
            if (usuario == null)
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            var principal = _serviceProvider.GetRequiredService<FormPrincipal>();

           
            principal.FormClosed += (s, args) => this.Close();

            this.Hide();      
            principal.Show(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var cadastroForm = _serviceProvider.GetRequiredService<FormCadastroUsuario>();
                cadastroForm.StartPosition = FormStartPosition.CenterParent;

                var result = cadastroForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Cadastro realizado com sucesso! Você já pode fazer login.",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                cadastroForm.Dispose(); // evita memory leak
                this.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir cadastro: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
