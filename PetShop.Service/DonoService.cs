using Microsoft.EntityFrameworkCore;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service
{
    public class DonoService
    {
        private readonly PetShopContext _context;

        public DonoService()
        {
            _context = new PetShopContext();
        }

        public void Cadastrar(Dono dono)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(dono.Nome))
                throw new ArgumentException("O nome do dono é obrigatório.");

            if (string.IsNullOrWhiteSpace(dono.Email))
                throw new ArgumentException("O email do dono é obrigatório.");

            if (string.IsNullOrWhiteSpace(dono.Senha))
                throw new ArgumentException("A senha do dono é obrigatória.");

            // Tratamento da cidade
            if (dono.CidadeObj == null)
                throw new ArgumentException("A cidade do dono deve ser informada.");

            var nomeCidade = dono.CidadeObj.Nome;
            var estadoCidade = dono.CidadeObj.Estado;

            // Verifica se a cidade já existe no banco
            var cidadeExistente = _context.Cidades
                .FirstOrDefault(c => c.Nome == nomeCidade && c.Estado == estadoCidade);

            if (cidadeExistente == null)
            {
                // Cria a cidade se não existir
                cidadeExistente = new Cidade
                {
                    Nome = nomeCidade,
                    Estado = estadoCidade
                };

                _context.Cidades.Add(cidadeExistente);
                _context.SaveChanges();
            }

            // Associa o dono à cidade existente
            dono.IdCidade = cidadeExistente.Id;
            dono.CidadeObj = cidadeExistente;

            // Salva o dono
            _context.Donos.Add(dono);
            _context.SaveChanges();
        }

        public Dono? ValidarLogin(string email, string senha)
        {
            return _context.Donos.FirstOrDefault(d => d.Email == email && d.Senha == senha);
        }

        public Dono? BuscarPorEmail(string email)
        {
            return _context.Donos.FirstOrDefault(d => d.Email == email);
        }

        public List<Dono> ListarTodos()
        {
            return _context.Donos.Include(d => d.Pets).Include(d => d.CidadeObj).ToList();
        }
    }
}
