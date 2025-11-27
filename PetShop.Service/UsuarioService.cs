using Microsoft.EntityFrameworkCore;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service
{
    public class UsuarioService : IDisposable
    {
        private readonly PetShopContext _context;

        public UsuarioService()
        {
            _context = new PetShopContext();
        }

       
        public void Cadastrar(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new ArgumentException("O nome do usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Login))
                throw new ArgumentException("O login do usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Email))
                throw new ArgumentException("O e-mail do usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Senha))
                throw new ArgumentException("A senha do usuário é obrigatória.");

            
            bool loginExiste = _context.Usuarios.Any(u => u.Login == usuario.Login);
            if (loginExiste)
                throw new ArgumentException("Este login já está cadastrado.");

            bool emailExiste = _context.Usuarios.Any(u => u.Email == usuario.Email);
            if (emailExiste)
                throw new ArgumentException("Este e-mail já está cadastrado.");

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

    
        public Usuario? ValidarLogin(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
                return null;

            return _context.Usuarios
                .FirstOrDefault(u => u.Login == login && u.Senha == senha);
        }

     
        public Usuario? BuscarPorId(int id)
        {
            return _context.Usuarios
                .Include(u => u.Vendas)
                .FirstOrDefault(u => u.Id == id);
        }

     
     

        public async Task<PageResult<Usuario>> ListarPaginadoAsync(PageRequest request)
        {
            return await _context.Usuarios
                .Include(u => u.Vendas)
                .AsQueryable()
                .PaginateAsync(request);
        }

       
        public void Atualizar(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.Find(usuario.Id);

            if (usuarioExistente == null)
                throw new Exception("Usuário não encontrado.");

            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Login = usuario.Login;
            usuarioExistente.Email = usuario.Email;

           
            if (!string.IsNullOrWhiteSpace(usuario.Senha))
                usuarioExistente.Senha = usuario.Senha;

            _context.SaveChanges();
        }

       
        public void Remover(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
