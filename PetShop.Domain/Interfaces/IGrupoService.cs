using PetshopStore.Domain.Entities;
using PetShop.Helpers.Pagination;

namespace PetShop.Domain.Interfaces
{
    public interface IGrupoService
    {
        void Cadastrar(Grupo grupo);
        void Atualizar(Grupo grupo);
        void Remover(int id);
        Grupo? BuscarPorId(int id);
        List<Grupo> Listar();
        Task<PageResult<Grupo>> ListarTodosPaginadoAsync(PageRequest pageRequest);
        Task<PageResult<Grupo>> BuscarPorNomePaginadoAsync(string nome, PageRequest pageRequest);
    }
}
