using PetShop.Helpers.Pagination;
using PetshopStore.Domain.Entities;


namespace PetShop.Domain.Interfaces
{
    public interface IServicoService
    {
        void Cadastrar(Servico servico);
        Servico? BuscarPorId(int id);
        Task<List<Servico>> ListarTodosAsync();
        Task<PageResult<Servico>> ListarPaginadosAsync(PageRequest request);
        void AtualizarServico(Servico servico);
        void RemoverServico(int id);
    }
}
