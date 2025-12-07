using PetShop.Helpers.Pagination;
using PetshopStore.Domain.Entities;


namespace PetShop.Domain.Interfaces
{
    public interface IProdutoService
    {
        void Cadastrar(Produto produto);
        Produto? BuscarPorId(int id);
        List<Produto> ListarTodos();
        Task<PageResult<Produto>> ListarTodosPaginadoAsync(PageRequest pageRequest);
        Task<PageResult<Produto>> ListarPorNomePaginadoAsync(string nome, PageRequest pageRequest);
        Task<PageResult<Produto>> ListarPorGrupoPaginadoAsync(int idGrupo, PageRequest pageRequest);
        Task<PageResult<Produto>> ListarEstoqueBaixoPaginadoAsync(int estoqueMinimo, PageRequest pageRequest);
        Task<PageResult<Produto>> ListarPorFaixaPrecoPaginadoAsync(
             decimal? precoMinimo,
             decimal? precoMaximo,
             PageRequest pageRequest);

        void Atualizar(Produto produto);

        void Remover(int id);

    }
}
