using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetShop.Repository.Base;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;
using System;

namespace PetShop.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestDonoPet()
        {
            using (var context = new PetShopContext())
            {
                var cidadeRepo = new BaseRepository<Cidade>(context);
                var donoRepo = new BaseRepository<Dono>(context);
                var petRepo = new BaseRepository<Pet>(context);

                // 1️⃣ Criar cidade
                var cidade = new Cidade
                {
                    Nome = "São Paulo",
                    Estado = "SP"
                };
                cidadeRepo.Insert(cidade);

                // 2️⃣ Criar dono
                var dono = new Dono
                {
                    Nome = "Luiza lima de castro Paro",
                    Documento = "123.456.789-00",
                    Telefone = "189810811",
                    Endereco = "Rua Santa Terezinha, 1932",
                    Bairro = "Centro",
                    Email = "Luizaparo@gmail.com",
                    CidadeObj = cidade 
                };
                donoRepo.Insert(dono);

                // 3️⃣ Criar pet vinculado ao dono
                var pet = new Pet
                {
                    Nome = "Luna",
                    Especie = "Cachorro",
                    Raca = "Vira lata",
                    Peso = 11M,
                    Sexo = "F",
                    DataNascimento = new DateTime(2020, 5, 10),
                    Dono = dono
                };
                petRepo.Insert(pet);

                Console.WriteLine(" Dono e Pet inseridos com sucesso!");
            }
        }
    }
}
