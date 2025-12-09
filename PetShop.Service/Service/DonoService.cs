using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Interfaces;
using PetShop.Helpers.Pagination;
using PetShop.Helpers.Security; // Adicionado para usar o PasswordHelper
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Service.Service
{
    public class DonoService : IDonoService
    {
        private readonly PetShopDbContext _context;

        public DonoService(PetShopDbContext context)
        {
            _context = context;
        }

        public void Cadastrar(Dono dono)
        {
            if (dono == null)
                throw new ArgumentException("O dono não pode ser nulo.");

            // Validações básicas
            if (string.IsNullOrWhiteSpace(dono.Nome))
                throw new ArgumentException("O nome do dono é obrigatório.");

            if (string.IsNullOrWhiteSpace(dono.Email))
                throw new ArgumentException("O email é obrigatório.");

            if (string.IsNullOrWhiteSpace(dono.Senha))
                throw new ArgumentException("A senha é obrigatória.");

            // --- Validação de Cidade ---
            if (dono.IdCidade <= 0)
                throw new ArgumentException("A cidade é obrigatória.");

            bool cidadeExiste = _context.Cidades.Any(c => c.Id == dono.IdCidade);
            if (!cidadeExiste)
                throw new ArgumentException("A cidade informada não existe.");

            // --- Validação de Email Único ---
            if (_context.Donos.Any(d => d.Email == dono.Email))
                throw new ArgumentException("Este email já está cadastrado.");

            // CRIPTOGRAFIA: Hash da senha antes de salvar
            dono.Senha = PasswordHelper.Hash(dono.Senha);

            _context.Donos.Add(dono);
            _context.SaveChanges();
        }

        // ===============================
        // LOGIN
        // ===============================
        public Dono? ValidarLogin(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                return null;

            // Gera o hash da senha informada para comparar com o banco
            var senhaHash = PasswordHelper.Hash(senha);

            return _context.Donos
                .Include(d => d.CidadeObj)
                .FirstOrDefault(d => d.Email == email && d.Senha == senhaHash);
        }

        // ===============================
        // BUSCAR POR ID
        // ===============================
        public Dono? BuscarPorId(int id)
        {
            return _context.Donos
                .Include(d => d.CidadeObj)
                .Include(d => d.Pets)
                .Include(d => d.Vendas)
                .FirstOrDefault(d => d.Id == id);
        }

        // ===============================
        // BUSCAR POR EMAIL
        // ===============================
        public Dono? BuscarPorEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return null;

            return _context.Donos
                .Include(d => d.CidadeObj)
                .FirstOrDefault(d => d.Email == email);
        }

        // ===============================
        // LISTAR TODOS
        // ===============================
        public List<Dono> ListarDonos() // Alterado para ListarDonos conforme sua interface original se necessário, ou Listar()
        {
            return _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .OrderBy(d => d.Nome)
                .ToList();
        }

        // ===============================
        // LISTAR PAGINADO
        // ===============================
        public async Task<PageResult<Dono>> ListarTodosPaginadoAsync(PageRequest pageRequest)
        {
            var query = _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .OrderBy(d => d.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

        // ===============================
        // LISTAR POR NOME (paginado)
        // ===============================
        public async Task<PageResult<Dono>> ListarPorNomePaginadoAsync(string nome, PageRequest pageRequest)
        {
            var query = _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
                query = query.Where(d => d.Nome.Contains(nome));

            query = query.OrderBy(d => d.Nome);

            return await query.PaginateAsync(pageRequest);
        }

        // ===============================
        // LISTAR POR CIDADE (paginado)
        // ===============================
        public async Task<PageResult<Dono>> ListarPorCidadePaginadoAsync(int idCidade, PageRequest pageRequest)
        {
            var query = _context.Donos
                .Include(d => d.Pets)
                .Include(d => d.CidadeObj)
                .Where(d => d.IdCidade == idCidade)
                .OrderBy(d => d.Nome)
                .AsQueryable();

            return await query.PaginateAsync(pageRequest);
        }

        // ===============================
        // ATUALIZAR
        // ===============================
        public void Atualizar(Dono dono)
        {
            var donoExistente = _context.Donos.Find(dono.Id);

            if (donoExistente == null)
                throw new Exception("Dono não encontrado.");

            // Atualiza os campos
            donoExistente.Nome = dono.Nome;
            donoExistente.Endereco = dono.Endereco;
            donoExistente.Telefone = dono.Telefone;
            donoExistente.Email = dono.Email;
            donoExistente.Documento = dono.Documento;
            donoExistente.Bairro = dono.Bairro;
            donoExistente.IdCidade = dono.IdCidade;

            // Se a senha foi informada, criptografa e atualiza
            if (!string.IsNullOrWhiteSpace(dono.Senha))
            {
                donoExistente.Senha = PasswordHelper.Hash(dono.Senha);
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
    }
}