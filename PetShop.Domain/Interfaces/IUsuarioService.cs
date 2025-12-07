using PetShop.Helpers.Pagination;
using PetshopStore.Domain.Entities;


namespace PetShop.Domain.Interfaces
{
    public interface IUsuarioService
    {
        void Cadastrar(Usuario usuario);
        Usuario? ValidarLogin(string login, string senha);
        Usuario? BuscarPorId(int id);
        Task<PageResult<Usuario>> ListarPaginadoAsync(PageRequest request);
        void Atualizar(Usuario usuario);
        void Remover(int id);
    }
}
