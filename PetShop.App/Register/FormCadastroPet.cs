using PetShop.Domain.Interfaces;
using PetshopStore.Domain.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.App.Forms
{
    public partial class FormCadastroPet : Form
    {
        private readonly IPetService _petService;
        private readonly IDonoService _donoService;
        private int? _idPetEdicao;

       
        public FormCadastroPet(IPetService petService, IDonoService donoService)
        {
            InitializeComponent();
            _petService = petService;
            _donoService = donoService;
            ConfigurarFormulario();
        }

        // Construtor para Edição
        public FormCadastroPet(IPetService petService, IDonoService donoService, int idPet)
            : this(petService, donoService)
        {
            _idPetEdicao = idPet;
            CarregarDadosParaEdicao(idPet);
        }

        private void FormCadastroPet_Load(object sender, EventArgs e)
        {
            
            CarregarDonos();
        }

        private void CarregarDonos()
        {
            try
            {
                
                var donos = _donoService.ListarDonos();

                cboDono.DataSource = donos;
                cboDono.DisplayMember = "Nome";
                cboDono.ValueMember = "Id";

                
                cboDono.DropDownStyle = ComboBoxStyle.DropDown;
                cboDono.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboDono.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                cboDono.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar donos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                // Captura os dados
                var nome = txtNome.Text.Trim();
                var especie = txtEspecie.Text.Trim();
                var raca = txtRaca.Text.Trim();
                var idade = (int)numIdade.Value;
                var peso = numPeso.Value;
                var sexo = cboSexo.Text;
                var idDono = (int)cboDono.SelectedValue;

                var pet = new Pet(
                    id: _idPetEdicao ?? 0,
                    nome: nome,
                    especie: especie,
                    raca: raca,
                    idade: idade,
                    idDono: idDono,
                    sexo: sexo,
                    peso: peso
                );

                if (_idPetEdicao.HasValue)
                {
                    _petService.AtualizarPet(pet);
                    MessageBox.Show("Pet atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _petService.CadastrarPet(pet);
                    MessageBox.Show("Pet cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar Pet: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("O nome do Pet é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (cboDono.SelectedIndex == -1 || cboDono.SelectedValue == null)
            {
                MessageBox.Show("Selecione o Dono do Pet.");
                cboDono.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                MessageBox.Show("Informe a espécie (ex: Cachorro, Gato).");
                txtEspecie.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboSexo.Text))
            {
                MessageBox.Show("Selecione o Sexo do Pet.");
                cboSexo.Focus();
                return false;
            }
            return true;
        }

        private void CarregarDadosParaEdicao(int id)
        {
            try
            {
                var pet = _petService.BuscarporId(id);
                if (pet != null)
                {
                    txtNome.Text = pet.Nome;
                    txtEspecie.Text = pet.Especie;
                    txtRaca.Text = pet.Raca;
                    numIdade.Value = pet.Idade;
                    numPeso.Value = pet.Peso;
                    cboSexo.Text = pet.Sexo;
                    cboDono.SelectedValue = pet.IdDono;

                    btnSalvar.Text = "Atualizar";
                    this.Text = "Edição de Pet";
                }
                else
                {
                    MessageBox.Show("Pet não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Cadastro de Pet";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}