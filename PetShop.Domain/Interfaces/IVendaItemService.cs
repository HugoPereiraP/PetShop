using PetShop.Helpers.Pagination;
using PetshopStore.Domain.Entities;


namespace PetShop.Domain.Interfaces
{
    public interface IVendaItemService
    {
        void Cadastrar(VendaItem item);
        VendaItem? BuscarPorId(int id);
        Task<PageResult<VendaItem>> ListarPaginadosAsync(PageRequest request);
        void Atualizar(VendaItem item);
        void Remover(int id);
    }
}
