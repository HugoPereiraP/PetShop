using Microsoft.EntityFrameworkCore;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service
{
    public class VendaService : IDisposable
    {
        private readonly PetShopContext _context;

        public VendaService()
        {
            _context = new PetShopContext();
        }

  
        public void Cadastrar(Venda venda, List<VendaItem> itens)
        {
            if (venda == null)
                throw new ArgumentException("A venda não pode ser nula.");

            if (venda.IdDono <= 0)
                throw new ArgumentException("O id do dono é obrigatório.");

            if (venda.IdUsuario <= 0)
                throw new ArgumentException("O id do usuário é obrigatório.");

            if (itens == null || itens.Count == 0)
                throw new ArgumentException("A venda deve conter pelo menos 1 item.");

           
            foreach (var item in itens)
            {
                if (item.IdProduto <= 0)
                    throw new ArgumentException("O item da venda deve ter um produto válido.");

                if (item.Quantidade <= 0)
                    throw new ArgumentException("A quantidade deve ser maior que zero.");

                if (item.ValorUnitario <= 0)
                    throw new ArgumentException("O valor unitário deve ser maior que zero.");
            }

            venda.Data = DateTime.Now;
            venda.ValorTotal = itens.Sum(i => i.Quantidade * i.ValorUnitario);

            _context.Vendas.Add(venda);
            _context.SaveChanges();

        
            foreach (var item in itens)
            {
                item.IdVenda = venda.Id;
                _context.VendaItems.Add(item);
            }

            _context.SaveChanges();
        }

        
        public Venda? BuscarPorId(int id)
        {
            return _context.Vendas
                .Include(v => v.Dono)
                .Include(v => v.Usuario)
                .Include(v => v.VendaItens)
                    .ThenInclude(i => i.Produto)
                .FirstOrDefault(v => v.Id == id);
        }

     
        public async Task<PageResult<Venda>> ListarPaginadosAsync(PageRequest request)
        {
            return await _context.Vendas
                .Include(v => v.Dono)
                .Include(v => v.Usuario)
                .OrderByDescending(v => v.Data)
                .AsQueryable()
                .PaginateAsync(request);
        }

       
        public void AtualizarVenda(Venda venda, List<VendaItem> itensAtualizados)
        {
            var vendaExistente = _context.Vendas
                .Include(v => v.VendaItens)
                .FirstOrDefault(v => v.Id == venda.Id);

            if (vendaExistente == null)
                throw new ArgumentException("A venda informada não existe.");

           
            vendaExistente.IdUsuario = venda.IdUsuario;
            vendaExistente.IdDono = venda.IdDono;

            
            _context.VendaItems.RemoveRange(vendaExistente.VendaItens);

            
            foreach (var item in itensAtualizados)
            {
                item.IdVenda = venda.Id;
                _context.VendaItems.Add(item);
            }

            
            vendaExistente.ValorTotal = itensAtualizados.Sum(i => i.Quantidade * i.ValorUnitario);

            _context.SaveChanges();
        }

       
        public void RemoverVenda(int id)
        {
            var venda = _context.Vendas
                .Include(v => v.VendaItens)
                .FirstOrDefault(v => v.Id == id);

            if (venda == null)
                throw new ArgumentException("A venda informada não existe.");

            _context.VendaItems.RemoveRange(venda.VendaItens);
            _context.Vendas.Remove(venda);
            _context.SaveChanges();
        }

        
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
