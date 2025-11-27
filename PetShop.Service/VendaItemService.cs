using Microsoft.EntityFrameworkCore;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service
{
    public class VendaItemService : IDisposable
    {
        private readonly PetShopContext _context;

        public VendaItemService()
        {
            _context = new PetShopContext();
        }

      
        public void Cadastrar(VendaItem item)
        {
            if (item == null)
                throw new ArgumentException("O item da venda não pode ser nulo.");

            if (item.IdVenda <= 0)
                throw new ArgumentException("O item deve estar vinculado a uma venda.");

            if (item.IdProduto <= 0)
                throw new ArgumentException("O produto informado é inválido.");

            if (item.Quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            if (item.ValorUnitario <= 0)
                throw new ArgumentException("O valor unitário deve ser maior que zero.");

            _context.VendaItems.Add(item);
            _context.SaveChanges();
        }

        
        public VendaItem? BuscarPorId(int id)
        {
            return _context.VendaItems
                .Include(vi => vi.Produto)
                .Include(vi => vi.Venda)
                .FirstOrDefault(vi => vi.Id == id);
        }

      
        public async Task<PageResult<VendaItem>> ListarPaginadosAsync(PageRequest request)
        {
            return await _context.VendaItems
                .Include(i => i.Produto)
                .Include(i => i.Venda)
                .OrderBy(i => i.Id)
                .AsQueryable()
                .PaginateAsync(request);
        }

      
        public void Atualizar(VendaItem item)
        {
            var itemExistente = _context.VendaItems.Find(item.Id);

            if (itemExistente == null)
                throw new ArgumentException("O item informado não existe.");

            if (item.IdProduto <= 0)
                throw new ArgumentException("O produto informado é inválido.");

            if (item.Quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            if (item.ValorUnitario <= 0)
                throw new ArgumentException("O valor unitário deve ser maior que zero.");

           
            itemExistente.IdProduto = item.IdProduto;
            itemExistente.Quantidade = item.Quantidade;
            itemExistente.ValorUnitario = item.ValorUnitario;

            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var item = _context.VendaItems.Find(id);

            if (item == null)
                throw new ArgumentException("O item informado não existe.");

            _context.VendaItems.Remove(item);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
