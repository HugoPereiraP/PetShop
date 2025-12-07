using PetshopStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Domain.Interfaces
{
    public interface IPetService
    {
        void CadastrarPet(Pet pet);
        Pet? BuscarporId(int id);
        IQueryable<Pet> ListarPets();
        IQueryable<Pet> ListarPorDono(int idDono);
        void AtualizarPet(Pet pet);
        void RemoverPet(int id);

    }
}
