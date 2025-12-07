using ReaLTaiizor.Forms;
using PetShop.Domain.Interfaces;
using PetshopStore.Domain.Entities;
using System;
using System.Windows.Forms;

namespace PetShop.App.Register
{
    public partial class FormCadastroUsuario : MaterialForm
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IGrupoService _grupoService;

        public FormCadastroUsuario(IUsuarioService usuarioService, IGrupoService grupoService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _grupoService = grupoService;
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                // Carrega os grupos no ComboBox (se você tiver)
                // var grupos = _grupoService.Get<Grupo>();
                // cboGrupo.DataSource = grupos;
                // cboGrupo.DisplayMember = "Nome";
                // cboGrupo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                string nome = txtNome.Text.Trim();
                string email = txtEmail.Text.Trim();
                string senha = txtSenha.Text.Trim();

                // Cria o novo usuário
                var usuario = new Usuario
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha,
                };

                
                _usuarioService.Cadastrar(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LimparCampos();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string confSenha = txtConfSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome do usuário!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o email do usuário!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email inválido!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Informe a senha!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(confSenha))
            {
                MessageBox.Show("Confirme a senha!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtConfSenha.Focus();
                return false;
            }

            if (senha != confSenha)
            {
                MessageBox.Show("As senhas não conferem!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtConfSenha.Focus();
                txtConfSenha.Clear();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente cancelar o cadastro?",
                                        "Confirmação",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Se não definiu DialogResult, define como Cancel
            if (this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}