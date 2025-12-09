using PetShop.Domain.Interfaces;
using PetshopStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.App.Forms
{
    public partial class FormCadastroDono : Form
    {
        private readonly IDonoService _donoService;
        private readonly ICidadeService _cidadeService;

        private int? _idDonoEdicao;

        // Construtor Principal
        public FormCadastroDono(IDonoService donoService, ICidadeService cidadeService)
        {
            InitializeComponent();
            _donoService = donoService;
            _cidadeService = cidadeService;
            ConfigurarFormulario();
        }

        // Construtor para Edição
        public FormCadastroDono(IDonoService donoService, ICidadeService cidadeService, int idDono)
            : this(donoService, cidadeService)
        {
            _idDonoEdicao = idDono;
            CarregarDadosParaEdicao(idDono);
        }

        private void FormCadastroDono_Load(object sender, EventArgs e)
        {
            CarregarCidades();
        }

        private void CarregarCidades()
        {
            try
            {
                var cidades = _cidadeService.Listar().ToList();

                cboCidade.DataSource = cidades;
                cboCidade.DisplayMember = "Nome";
                cboCidade.ValueMember = "Id";

                // Configuração de AutoComplete
                cboCidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboCidade.AutoCompleteSource = AutoCompleteSource.ListItems;

                cboCidade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                // Captura os dados da tela
                var nome = txtNome.Text.Trim();
                var email = txtEmail.Text.Trim();

                // IMPORTANTE: MaskedTextBox pode vir com formatação. 
                // Abaixo eu removo caracteres não numéricos para garantir que salve limpo no banco.
                var cpf = txtDocumento.Text.Replace(".", "").Replace("-", "").Trim();
                var telefone = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim();

                var endereco = txtEndereco.Text.Trim();
                var bairro = txtBairro.Text.Trim();
                var senha = txtSenha.Text.Trim();

                var idCidade = (int)cboCidade.SelectedValue;

                var dono = new Dono(
                    id: _idDonoEdicao ?? 0,
                    nome: nome,
                    endereco: endereco,
                    documento: cpf, // Envia limpo
                    bairro: bairro,
                    idCidade: idCidade,
                    email: email,
                    telefone: telefone, // Envia limpo
                    senha: senha
                );

                if (_idDonoEdicao.HasValue)
                {
                    _donoService.Atualizar(dono);
                    MessageBox.Show("Dono atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _donoService.Cadastrar(dono);
                    MessageBox.Show("Dono cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            // Verifica se o MaskedTextBox foi preenchido (se só tem a máscara, o Length é pequeno ou TextMaskFormat controla)
            if (!txtDocumento.MaskCompleted)
            {
                MessageBox.Show("O CPF está incompleto.");
                txtDocumento.Focus();
                return false;
            }
            if (cboCidade.SelectedIndex == -1 || cboCidade.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma Cidade válida.");
                cboCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("A senha é obrigatória.");
                txtSenha.Focus();
                return false;
            }
            return true;
        }

        private void CarregarDadosParaEdicao(int id)
        {
            try
            {
                var dono = _donoService.BuscarPorId(id);
                if (dono != null)
                {
                    txtNome.Text = dono.Nome;
                    txtDocumento.Text = dono.Documento; // O MaskedTextBox aplicará a máscara se o dado vier limpo do banco
                    txtEmail.Text = dono.Email;
                    txtTelefone.Text = dono.Telefone;
                    txtEndereco.Text = dono.Endereco;
                    txtBairro.Text = dono.Bairro;
                    txtSenha.Text = dono.Senha;

                    cboCidade.SelectedValue = dono.IdCidade;

                    btnSalvar.Text = "Atualizar";
                    this.Text = "Edição de Dono";
                }
                else
                {
                    MessageBox.Show("Dono não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados para edição: {ex.Message}");
            }
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Cadastro de Dono";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}