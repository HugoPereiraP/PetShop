using PetShop.Domain.Interfaces;
using PetshopStore.Domain.Entities;
using ReaLTaiizor.Forms;


namespace PetShop.App.Forms
{
    public partial class FormCadastroDono : MaterialForm
    {
        private readonly IDonoService _donoService;
        private readonly ICidadeService _cidadeService; // 1. Serviço de cidade adicionado

        private int? _idDonoEdicao;

        // Construtor Principal com Injeção de Dependência
        public FormCadastroDono(IDonoService donoService, ICidadeService cidadeService)
        {
            InitializeComponent();
            _donoService = donoService;
            _cidadeService = cidadeService; // 2. Atribuição do serviço
            ConfigurarFormulario();
        }

        // Construtor para Edição (recebe o ID do dono a editar e os serviços)
        public FormCadastroDono(IDonoService donoService, ICidadeService cidadeService, int idDono)
            : this(donoService, cidadeService)
        {
            _idDonoEdicao = idDono;
            CarregarDadosParaEdicao(idDono);
        }

        private void FormCadastroDono_Load(object sender, EventArgs e)
        {
            // Carrega as cidades assim que o formulário abre
            CarregarCidades();
        }

        private void CarregarCidades()
        {
            try
            {
                // 3. Busca a lista real do banco de dados
                var cidades = _cidadeService.Listar().ToList();

                cboCidade.DataSource = cidades;
                cboCidade.DisplayMember = "Nome"; // Certifique-se que a classe Cidade tem a prop 'Nome'
                cboCidade.ValueMember = "Id";     // Certifique-se que a classe Cidade tem a prop 'Id' (BaseEntity)

                cboCidade.SelectedIndex = -1; // Deixa o combo vazio inicialmente
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
                var cpf = txtDocumento.Text.Trim();
                var telefone = txtTelefone.Text.Trim();
                var endereco = txtEndereco.Text.Trim();
                var bairro = txtBairro.Text.Trim();
                var senha = txtSenha.Text.Trim();

                // Pega o ID da cidade selecionada (ValueMember)
                var idCidade = (int)cboCidade.SelectedValue;

                // Cria o objeto usando o construtor da sua entidade
                var dono = new Dono(
                    id: _idDonoEdicao ?? 0,
                    nome: nome,
                    endereco: endereco,
                    documento: cpf,
                    bairro: bairro,
                    idCidade: idCidade,
                    email: email,
                    telefone: telefone,
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

                this.Close(); // Fecha o formulário e retorna para a listagem (se houver)
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
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("O campo Documento é obrigatório.");
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
                    txtDocumento.Text = dono.Documento;
                    txtEmail.Text = dono.Email;
                    txtTelefone.Text = dono.Telefone;
                    txtEndereco.Text = dono.Endereco;
                    txtBairro.Text = dono.Bairro;
                    txtSenha.Text = dono.Senha;

                    // Seleciona a cidade correta no combobox
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