using PetShop.Domain.Interfaces;
using PetShop.Helpers.Pagination;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Service.Service
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly PetShopDbContext _context;

        public AgendamentoService(PetShopDbContext context)
        {
            _context = context;
        }

        public void Cadastrar(Agendamento agendamento)
        {
            ValidarAgendamento(agendamento);
            _context.Agendamentos.Add(agendamento);
            _context.SaveChanges();
        }

        public void Atualizar(Agendamento agendamento)
        {
            if (agendamento.Id <= 0)
                throw new ArgumentException("Id inválido para atualização.");

            ValidarAgendamento(agendamento);
            _context.Agendamentos.Update(agendamento);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var obj = _context.Agendamentos.Find(id);

            if (obj == null)
                throw new ArgumentException("Agendamento não encontrado.");

            _context.Agendamentos.Remove(obj);
            _context.SaveChanges();
        }

        public Agendamento BuscarPorId(int id)
        {
            return _context.Agendamentos.Find(id);
        }

        public IEnumerable<Agendamento> Listar()
        {
            return _context.Agendamentos.ToList();
        }

        private void ValidarAgendamento(Agendamento agendamento)
        {
            if (agendamento == null)
                throw new ArgumentNullException(nameof(agendamento));

            if (agendamento.IdPet <= 0)
                throw new ArgumentException("O agendamento deve estar vinculado a um pet.");

            if (agendamento.IdServico <= 0)
                throw new ArgumentException("O agendamento deve estar vinculado a um serviço.");

            if (agendamento.DataHora < DateTime.Now)
                throw new ArgumentException("A data e hora do agendamento não podem ser no passado.");

            if (agendamento.ValorTotal < 0)
                throw new ArgumentException("O valor total não pode ser negativo.");

            if (string.IsNullOrWhiteSpace(agendamento.Status))
                agendamento.Status = "Agendado";
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public List<Agendamento> ListarAgendamentos()
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<Agendamento>> ListarTodosPaginadoAsync(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<Agendamento>> ListarPorPetPaginadoAsync(int idPet, PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<Agendamento>> ListarPorServicoPaginadoAsync(int idServico, PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }
    }
}
