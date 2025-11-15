using Microsoft.EntityFrameworkCore;
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

        public Dono? BuscarPorId(string email)
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
                .ToList();
        }

        
        public IQueryable<Dono> ListarTodosPaginado()
        {
            var query = _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .OrderBy(d => d.Nome)
                .AsQueryable();


        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
