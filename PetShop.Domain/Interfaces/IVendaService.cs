using PetShop.Helpers.Pagination;
using PetshopStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetShop.Domain.Interfaces
{
    public interface IVendaService
    {
        void Cadastrar(Venda venda, List<VendaItem> itens);
        Venda? BuscarPorId(int id);
        Task<PageResult<Venda>> ListarPaginadosAsync(PageRequest request);
        void AtualizarVenda(Venda venda, List<VendaItem> itensAtualizados);
        void RemoverVenda(int id);
    }
}
