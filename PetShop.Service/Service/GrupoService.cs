using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Interfaces;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Service
{
    public class GrupoService : IGrupoService
    {
        private readonly PetShopDbContext _context;

        public GrupoService(PetShopDbContext context)
        {
            _context = context;
        }

        public void Cadastrar(Grupo grupo)
        {
            if (grupo == null)
                throw new ArgumentNullException(nameof(grupo));

            if (string.IsNullOrWhiteSpace(grupo.Nome))
                throw new ArgumentException("O nome do grupo é obrigatório.");

            bool existe = _context.Grupos.Any(g => g.Nome == grupo.Nome);
            if (existe)
                throw new ArgumentException("Já existe um grupo com este nome.");

            _context.Grupos.Add(grupo);
            _context.SaveChanges();
        }

        public void Atualizar(Grupo grupo)
        {
            var grupoExistente = _context.Grupos.Find(grupo.Id);
            if (grupoExistente == null)
                throw new Exception("Grupo não encontrado.");

            if (string.IsNullOrWhiteSpace(grupo.Nome))
                throw new ArgumentException("O nome do grupo é obrigatório.");

            grupoExistente.Nome = grupo.Nome;
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var grupo = _context.Grupos.Find(id);
            if (grupo == null)
                throw new Exception("Grupo não encontrado.");

            _context.Grupos.Remove(grupo);
            _context.SaveChanges();
        }

        public Grupo? BuscarPorId(int id)
        {
            return _context.Grupos
                .Include(g => g.Produtos)
                .FirstOrDefault(g => g.Id == id);
        }

        public List<Grupo> Listar()
        {
            return _context.Grupos
                .Include(g => g.Produtos)
                .OrderBy(g => g.Nome)
                .ToList();
        }

        public async Task<PageResult<Grupo>> ListarTodosPaginadoAsync(PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Grupos
                .Include(g => g.Produtos)
                .OrderBy(g => g.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

        public async Task<PageResult<Grupo>> BuscarPorNomePaginadoAsync(string nome, PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Grupos
                .Include(g => g.Produtos)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
                query = query.Where(g => g.Nome.Contains(nome));

            query = query.OrderBy(g => g.Nome);

            return await query.PaginateAsync(pageRequest);
        }
    }
}
