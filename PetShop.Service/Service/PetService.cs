using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Interfaces;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Service
{
    public class PetService : IPetService
    {
        private readonly PetShopDbContext _context;

        public PetService(PetShopDbContext context)
        {
            _context =  context;
        }

        public void CadastrarPet(Pet pet)
        {
            if (string.IsNullOrWhiteSpace(pet.Nome))
                throw new ArgumentException("O nome do Pet é obrigatório!");
            if (string.IsNullOrEmpty(pet.Especie))
                throw new ArgumentException("A espécie do Pet é obrigatória!");
            if (string.IsNullOrEmpty(pet.Raca))
                throw new ArgumentException("A raça do Pet é obrigatória!");
            if (string.IsNullOrEmpty(pet.Sexo))
                throw new ArgumentException("O sexo do Pet é obrigatório!");

            var donoExiste = _context.Donos.Any(d => d.Id == pet.IdDono);
            if (!donoExiste)
                throw new ArgumentException("O dono informado não existe!");

            _context.Pets.Add(pet);
            _context.SaveChanges();
        }

        public Pet? BuscarporId(int id)
        {
                return _context.Pets
                .Include(p => p.Dono)
                .FirstOrDefault(p => p.Id == id);
        }

        
        public IQueryable<Pet> ListarPets()
        {
            return _context.Pets
                .Include(p => p.Dono)
                .AsQueryable();
        }

        
        public IQueryable<Pet> ListarPorDono(int idDono)
        {
            return _context.Pets
                .Where(p => p.IdDono == idDono)
                .Include(p => p.Dono)
                .AsQueryable();
        }

        public void AtualizarPet(Pet pet)
        {
            var petExiste = _context.Pets.Find(pet.Id);
            if (petExiste == null)
                throw new Exception("Pet não encontrado");

            petExiste.Nome = pet.Nome;
            petExiste.Especie = pet.Especie;
            petExiste.Raca = pet.Raca;
            petExiste.Idade = pet.Idade;
            petExiste.Peso = pet.Peso;
            petExiste.Sexo = pet.Sexo;

            _context.SaveChanges();
        }

        public void RemoverPet(int id)
        {
            var pet = _context.Pets.Find(id);
            if (pet == null)
                throw new Exception("Pet não encontrado ");
            _context.Pets.Remove(pet);
            _context.SaveChanges();
        }
    }
}
