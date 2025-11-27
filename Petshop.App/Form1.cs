using MaterialSkin;
using MaterialSkin.Controls;
using PetShop.Service;
using PetshopStore.Domain.Entities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop.App
{
    public partial class FormServico : MaterialForm
    {
        private readonly ServicoService _service = new ServicoService();
        private int? editingId;

        public FormServico()
        {
            InitializeComponent();
            ConfigureMaterialDesign();
        }

        // ---------------------- CONFIGURAÇÃO -------------------------
        private void ConfigureMaterialDesign()
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Green500,
                Primary.Green700,
                Primary.Green200,
                Accent.Green100,
                TextShade.WHITE
            );
        }

        // ---------------------- UTILITÁRIOS --------------------------
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            mtbData.Clear();
            editingId = null;
        }

        private async Task CarregarServicosAsync()
        {
            var lista = await _service.ListarTodosAsync();
            dataGridViewList.DataSource = lista;
        }

        private async Task PopulateGrid()
        {
            await CarregarServicosAsync();
        }

        private void Deletar(int id)
        {
            _service.RemoverServico(id);
        }

        // ---------------------- EVENTOS DO FORM ----------------------
        private async void FormServico_Shown(object sender, EventArgs e)
        {
            await CarregarServicosAsync();
        }

        // ---------------------- BOTÃO CADASTRAR ----------------------
        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DateTime.TryParse(mtbData.Text, out DateTime data))
                {
                    MessageBox.Show("Data inválida!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O nome é obrigatório.");
                    return;
                }

                if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
                {
                    MessageBox.Show("Preço inválido!");
                    return;
                }

                var servico = new Servico
                {
                    Id = editingId ?? 0,
                    Nome = txtNome.Text,
                    Descricao = txtDescricao.Text,
                    Preco = preco
                };

                if (editingId == null)
                    _service.Cadastrar(servico);
                else
                    _service.AtualizarServico(servico);

                await CarregarServicosAsync();

                MessageBox.Show(editingId == null
                    ? "Serviço cadastrado com sucesso!"
                    : "Serviço atualizado com sucesso!");

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}");
            }
        }

        // ---------------------- BOTÃO EXCLUIR ------------------------
        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item para excluir.");
                return;
            }

            if (MessageBox.Show(
                "Você tem certeza que deseja excluir?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes)
            {
                int id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;

                Deletar(id);
                await PopulateGrid();

                MessageBox.Show("Item excluído com sucesso!");
            }
        }

        // ---------------------- BOTÃO EDITAR --------------------------
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um serviço para editar.");
                return;
            }

            var row = dataGridViewList.SelectedRows[0];

            editingId = (int)row.Cells["Id"].Value;
            txtNome.Text = row.Cells["Nome"].Value.ToString();
            txtDescricao.Text = row.Cells["Descricao"].Value.ToString();
            txtPreco.Text = row.Cells["Preco"].Value.ToString();
        }

        // ---------------------- BOTÃO NOVO ---------------------------
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos liberados para novo cadastro.");
        }

        // ---------------------- BOTÃO ATUALIZAR ----------------------
        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            await CarregarServicosAsync();
        }

        // ---------------------- BOTÃO CANCELAR -----------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Deseja realmente cancelar?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes)
            {
                LimparCampos();
            }
        }
    }
}
