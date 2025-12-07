using PetShop.Domain.Interfaces;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Service.Service
{
    public class CidadeService : ICidadeService 
    {
        private readonly PetShopDbContext _context;

        public CidadeService(PetShopDbContext context)
        {
            _context = context;
        }

        public void Cadastrar(Cidade cidade)
        {
            if (cidade == null)
                throw new ArgumentNullException(nameof(cidade), "A cidade não pode ser nula.");

            if (string.IsNullOrWhiteSpace(cidade.Nome))
                throw new ArgumentException("O nome da cidade é obrigatório.");

            if (string.IsNullOrWhiteSpace(cidade.Estado))
                throw new ArgumentException("O estado é obrigatório.");

            _context.Cidades.Add(cidade);
            _context.SaveChanges();
        }

        public void Atualizar(Cidade cidade)
        {
            if (cidade == null)
                throw new ArgumentNullException(nameof(cidade));

            if (cidade.Id <= 0)
                throw new ArgumentException("Id inválido para atualização.");

            _context.Cidades.Update(cidade);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var cidade = _context.Cidades.Find(id);

            if (cidade == null)
                throw new ArgumentException("Cidade não encontrada.");

            _context.Cidades.Remove(cidade);
            _context.SaveChanges();
        }

        public Cidade BuscarPorId(int id)
        {
            return _context.Cidades.Find(id);
        }

        public IEnumerable<Cidade> Listar()
        {
            return _context.Cidades.ToList();
        }
    }
}
