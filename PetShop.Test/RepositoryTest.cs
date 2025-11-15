using PetShop.Repository.Base;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting; // Adicione este 'using' para [TestClass] e [TestMethod]
using System; // Adicione este 'using' para Guid e DateTime

namespace PetShop.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestInserirDonoEPet()
        {
            using var context = new PetShopContext();
            var cidadeRepo = new BaseRepository<Cidade>(context);
            var donoRepo = new BaseRepository<Dono>(context);
            var petRepo = new BaseRepository<Pet>(context);

        
            context.ChangeTracker.Clear();

        
            var cidade = new Cidade
            {
                Nome = "São Paulo",
                Estado = "SP"
            };
            cidadeRepo.Insert(cidade);

            // 2️⃣ Criar dono
            var dono = new Dono
            {
                Nome = "Luiza Lima de Castro Paro",
                Documento = "123.456.789-00",
                Telefone = "189810811",
                Endereco = "Rua Santa Terezinha, 1932",
                Bairro = "Centro",
                // Gerar um email único para evitar falhas em testes repetidos
                Email = $"luiza_{Guid.NewGuid().ToString().Substring(0, 8)}@gmail.com",
                Senha = "senha123",
                IdCidade = cidade.Id 
            };
            donoRepo.Insert(dono);


            var pet = new Pet
            {
                Nome = "Luna",
                Especie = "Cachorro",
                Raca = "Vira lata",
                Peso = 11M,
                Sexo = "F",
                Idade = 12,
                IdDono = dono.Id
            };
            petRepo.Insert(pet);

            Console.WriteLine("✅ Dono e Pet inseridos com sucesso!");


            using var assertContext = new PetShopContext();
            var petSalvo = assertContext.Set<Pet>().Find(pet.Id);

            Assert.IsNotNull(petSalvo, "O Pet não foi salvo no banco.");
            Assert.AreEqual("Luna", petSalvo.Nome, "O nome do Pet está incorreto.");
            Assert.AreEqual(dono.Id, petSalvo.IdDono, "O ID do Dono vinculado ao Pet está incorreto.");

            var donoSalvo = assertContext.Set<Dono>().Find(dono.Id);
            Assert.IsNotNull(donoSalvo, "O Dono não foi salvo no banco.");
            Assert.AreEqual(cidade.Id, donoSalvo.IdCidade, "O ID da Cidade vinculado ao Dono está incorreto.");
        }
    }
}