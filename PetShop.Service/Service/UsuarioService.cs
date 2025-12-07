using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Interfaces;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly PetShopDbContext _context;

        public UsuarioService(PetShopDbContext context)
        {
            _context = context;
        }

        // Cadastrar usuário
        public void Cadastrar(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new ArgumentException("O nome do usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Email))
                throw new ArgumentException("O email é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Senha))
                throw new ArgumentException("A senha é obrigatória.");

            var existe = _context.Usuarios.Any(u => u.Email == usuario.Email);
            if (existe)
                throw new ArgumentException("Já existe um usuário com esse email.");

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // Validar login
        public Usuario? ValidarLogin(string login, string senha)
        {
            return _context.Usuarios
                .FirstOrDefault(u => u.Email == login && u.Senha == senha);
        }

        // Buscar por ID
        public Usuario? BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        // Listar paginado
        public async Task<PageResult<Usuario>> ListarPaginadoAsync(PageRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (request.PageNumber < 1)
                request.PageNumber = 1;

            if (request.PageSize < 1)
                request.PageSize = 10;

            var query = _context.Usuarios
                .OrderBy(u => u.Nome)
                .AsQueryable();

            return await query.PaginateAsync(request);
        }

        // Atualizar usuário
        public void Atualizar(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.Find(usuario.Id);
            if (usuarioExistente == null)
                throw new Exception("Usuário não encontrado.");

            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new ArgumentException("O nome do usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Email))
                throw new ArgumentException("O email é obrigatório.");

            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Email = usuario.Email;
            usuarioExistente.Senha = usuario.Senha;

            _context.SaveChanges();
        }

        // Remover usuário
        public void Remover(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}
