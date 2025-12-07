using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Interfaces;


namespace PetShop.Service.Service
{
        public class ServicoService : IServicoService
    {
        private readonly PetShopDbContext _context;

        public ServicoService(PetShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<Servico>> ListarTodosAsync()
        {
            return await _context.Servicos
                .OrderBy(s => s.Nome)
                .ToListAsync();
        }
        public void Cadastrar(Servico servico)
        {
            if(string.IsNullOrEmpty(servico.Nome))
                throw new ArgumentException("O nome do serviço é obrigatório.");
            if(servico.Preco <= 0)
                throw new ArgumentException("O preço do serviço deve ser maior que zero.");
            if(string.IsNullOrEmpty(servico.Descricao))
               throw new ArgumentException("A descrição do serviço é obrigatória.");

            _context.Servicos.Add(servico); 
            _context.SaveChanges(); 


        }
        public Servico? BuscarPorId(int id)
        {
            return _context.Servicos
                .FirstOrDefault(s => s.Id == id);
        }

        public async Task <PageResult<Servico>> ListarPaginadosAsync(PageRequest request)
        {
            return await _context.Servicos
                .OrderBy(s => s.Nome)
                .AsQueryable()
                .PaginateAsync(request);
        }
        public void AtualizarServico(Servico servico)
        {
            var servicoExiste = _context.Servicos.Find(servico.Id);
            if(servicoExiste == null)
                throw new ArgumentException("O serviço informado não existe.");

                servicoExiste.Nome = servico.Nome;  
                servicoExiste.Descricao = servico.Descricao;
                servicoExiste.Preco = servico.Preco;

            _context.SaveChanges();

        }

        public void RemoverServico(int id)
        {
            var servico = _context.Servicos.Find(id);
            if(servico == null)
                throw new ArgumentException("O serviço informado não existe.");

            _context.Servicos.Remove(servico);
            _context.SaveChanges();
        }
    }
}
