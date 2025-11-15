using Microsoft.EntityFrameworkCore;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service
{
    public class ProdutoService : IDisposable
    {
        private readonly PetShopContext _context;

        public ProdutoService()
        {
            _context = new PetShopContext();
        }

        public void Cadastrar(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Nome))
                throw new ArgumentException("O nome do produto é obrigatório.");

            if (produto.Preco <= 0)
                throw new ArgumentException("O preço deve ser maior que zero.");

            if (produto.Quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            if (string.IsNullOrWhiteSpace(produto.UnidadeVenda))
                throw new ArgumentException("A unidade de venda é obrigatória.");

            if (produto.IdGrupo <= 0)
                throw new ArgumentException("O grupo do produto é obrigatório.");

            var grupoExiste = _context.Grupos.Any(g => g.Id == produto.IdGrupo);
            if (!grupoExiste)
                throw new ArgumentException("O grupo informado não existe.");

            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public Produto? BuscarPorId(int id)
        {
            return _context.Produtos
                .Include(p => p.Grupo)
                .FirstOrDefault(p => p.Id == id);
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos
                .Include(p => p.Grupo)
                .OrderBy(p => p.Nome)
                .ToList();
        }

       
        public async Task<PageResult<Produto>> ListarTodosPaginadoAsync(PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Produtos
                .Include(p => p.Grupo)
                .OrderBy(p => p.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

       
        public async Task<PageResult<Produto>> ListarPorNomePaginadoAsync(string nome, PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Produtos
                .Include(p => p.Grupo)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                query = query.Where(p => p.Nome.Contains(nome));
            }

            query = query.OrderBy(p => p.Nome);

            return await query.PaginateAsync(pageRequest);
        }

        public async Task<PageResult<Produto>> ListarPorGrupoPaginadoAsync(int idGrupo, PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Produtos
                .Include(p => p.Grupo)
                .Where(p => p.IdGrupo == idGrupo)
                .OrderBy(p => p.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

        
        public async Task<PageResult<Produto>> ListarEstoqueBaixoPaginadoAsync(int estoqueMinimo, PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Produtos
                .Include(p => p.Grupo)
                .Where(p => p.Estoque < estoqueMinimo)
                .OrderBy(p => p.Estoque)
                .ThenBy(p => p.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

      
        public async Task<PageResult<Produto>> ListarPorFaixaPrecoPaginadoAsync(
            decimal? precoMinimo,
            decimal? precoMaximo,
            PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Produtos
                .Include(p => p.Grupo)
                .AsQueryable();

            if (precoMinimo.HasValue)
            {
                query = query.Where(p => p.Preco >= precoMinimo.Value);
            }

            if (precoMaximo.HasValue)
            {
                query = query.Where(p => p.Preco <= precoMaximo.Value);
            }

            query = query.OrderBy(p => p.Preco);

            return await query.PaginateAsync(pageRequest);
        }

        public void Atualizar(Produto produto)
        {
            var produtoExiste = _context.Produtos.Find(produto.Id);
            if (produtoExiste == null)
                throw new Exception("Produto não encontrado.");

            if (string.IsNullOrWhiteSpace(produto.Nome))
                throw new ArgumentException("O nome do produto é obrigatório.");

            if (produto.Preco <= 0)
                throw new ArgumentException("O preço deve ser maior que zero.");

            if (produto.IdGrupo <= 0)
                throw new ArgumentException("O grupo do produto é obrigatório.");

            var grupoExiste = _context.Grupos.Any(g => g.Id == produto.IdGrupo);
            if (!grupoExiste)
                throw new ArgumentException("O grupo informado não existe.");

            produtoExiste.Nome = produto.Nome;
            produtoExiste.Preco = produto.Preco;
            produtoExiste.Quantidade = produto.Quantidade;
            produtoExiste.UnidadeVenda = produto.UnidadeVenda;
            produtoExiste.IdGrupo = produto.IdGrupo;
            produtoExiste.Estoque = produto.Estoque;

            _context.SaveChanges();
        }

      
        public void AtualizarEstoque(int idProduto, int novoEstoque)
        {
            var produto = _context.Produtos.Find(idProduto);
            if (produto == null)
                throw new Exception("Produto não encontrado.");

            if (novoEstoque < 0)
                throw new ArgumentException("O estoque não pode ser negativo.");

            produto.Estoque = novoEstoque;
            _context.SaveChanges();
        }

       
        public void AdicionarEstoque(int idProduto, int quantidade)
        {
            var produto = _context.Produtos.Find(idProduto);
            if (produto == null)
                throw new Exception("Produto não encontrado.");

            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            produto.Estoque += quantidade;
            _context.SaveChanges();
        }

        public void RemoverEstoque(int idProduto, int quantidade)
        {
            var produto = _context.Produtos.Find(idProduto);
            if (produto == null)
                throw new Exception("Produto não encontrado.");

            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            if (produto.Estoque < quantidade)
                throw new InvalidOperationException("Estoque insuficiente.");

            produto.Estoque -= quantidade;
            _context.SaveChanges();
        }

        public bool VerificarEstoque(int idProduto, int quantidadeNecessaria)
        {
            var produto = _context.Produtos.Find(idProduto);
            if (produto == null)
                return false;

            return produto.Estoque >= quantidadeNecessaria;
        }

        public void Remover(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
                throw new Exception("Produto não encontrado.");

            var temVendas = _context.ItensVendas.Any(vi => vi.IdProduto == id);
            if (temVendas)
                throw new InvalidOperationException("Não é possível remover um produto que possui vendas associadas.");

            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}