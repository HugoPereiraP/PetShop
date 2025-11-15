using Microsoft.EntityFrameworkCore;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service
{
    public class DonoService : IDisposable
    {
        private readonly PetShopContext _context;

        public DonoService()
        {
            _context = new PetShopContext();
        }

        public void Cadastrar(Dono dono)
        {
            if (string.IsNullOrWhiteSpace(dono.Nome))
                throw new ArgumentException("O nome do dono é obrigatório.");

            if (string.IsNullOrWhiteSpace(dono.Email))
                throw new ArgumentException("O email do dono é obrigatório.");

            if (string.IsNullOrWhiteSpace(dono.Senha))
                throw new ArgumentException("A senha do dono é obrigatória.");

            if (dono.IdCidade <= 0 && dono.CidadeObj == null)
                throw new ArgumentException("A cidade do dono deve ser informada.");

            if (dono.CidadeObj != null)
            {
                var nomeCidade = dono.CidadeObj.Nome?.Trim();
                var estadoCidade = dono.CidadeObj.Estado?.Trim();

                if (string.IsNullOrWhiteSpace(nomeCidade) || string.IsNullOrWhiteSpace(estadoCidade))
                    throw new ArgumentException("Nome e Estado da cidade são obrigatórios.");

                var cidadeExistente = _context.Cidades
                    .FirstOrDefault(c => c.Nome == nomeCidade && c.Estado == estadoCidade);

                if (cidadeExistente == null)
                {
                    cidadeExistente = new Cidade
                    {
                        Nome = nomeCidade,
                        Estado = estadoCidade
                    };

                    _context.Cidades.Add(cidadeExistente);
                    _context.SaveChanges();
                }

                dono.IdCidade = cidadeExistente.Id;
                dono.CidadeObj = null;
            }
            else if (dono.IdCidade > 0)
            {
                var cidadeExiste = _context.Cidades.Any(c => c.Id == dono.IdCidade);
                if (!cidadeExiste)
                    throw new ArgumentException("A cidade informada não existe.");
            }

            var emailExistente = _context.Donos.Any(d => d.Email == dono.Email);
            if (emailExistente)
                throw new ArgumentException("Este email já está cadastrado.");

            _context.Donos.Add(dono);
            _context.SaveChanges();
        }

        public Dono? ValidarLogin(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                return null;

            return _context.Donos
                .Include(d => d.CidadeObj)
                .FirstOrDefault(d => d.Email == email && d.Senha == senha);
        }

        public Dono? BuscarPorId(int id)
        {
            return _context.Donos
                .Include(d => d.CidadeObj)
                .Include(d => d.Pets)
                .FirstOrDefault(d => d.Id == id);
        }

        public Dono? BuscarPorEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return null;

            return _context.Donos
                .Include(d => d.CidadeObj)
                .FirstOrDefault(d => d.Email == email);
        }

        public List<Dono> ListarTodos()
        {
            return _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .OrderBy(d => d.Nome)
                .ToList();
        }

        
        public async Task<PageResult<Dono>> ListarTodosPaginadoAsync(PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .OrderBy(d => d.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

       
        public async Task<PageResult<Dono>> ListarPorNomePaginadoAsync(string nome, PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                query = query.Where(d => d.Nome.Contains(nome));
            }

            query = query.OrderBy(d => d.Nome);

            return await query.PaginateAsync(pageRequest);
        }

        
        public async Task<PageResult<Dono>> ListarPorCidadePaginadoAsync(int idCidade, PageRequest pageRequest)
        {
            if (pageRequest == null)
                throw new ArgumentNullException(nameof(pageRequest));

            if (pageRequest.PageNumber < 1)
                pageRequest.PageNumber = 1;

            if (pageRequest.PageSize < 1)
                pageRequest.PageSize = 10;

            var query = _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .Where(d => d.IdCidade == idCidade)
                .OrderBy(d => d.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

        public void Atualizar(Dono dono)
        {
            var donoExiste = _context.Donos.Find(dono.Id);
            if (donoExiste == null)
                throw new Exception("Dono não encontrado.");

            donoExiste.Nome = dono.Nome;
            donoExiste.Endereco = dono.Endereco;
            donoExiste.Telefone = dono.Telefone;
            donoExiste.Email = dono.Email;
            donoExiste.Documento = dono.Documento;
            donoExiste.Bairro = dono.Bairro;
            donoExiste.IdCidade = dono.IdCidade;

            if (!string.IsNullOrWhiteSpace(dono.Senha))
            {
                donoExiste.Senha = dono.Senha;
            }

            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var dono = _context.Donos.Find(id);
            if (dono == null)
                throw new Exception("Dono não encontrado.");

            _context.Donos.Remove(dono);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}