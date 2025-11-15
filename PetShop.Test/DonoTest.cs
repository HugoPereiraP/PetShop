using PetShop.Repository.Base;
using PetShop.Repository.Context;
using PetshopStore.Domain.Entities;

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

        
        var dono = new Dono
        {
            Nome = "Luiza Lima de Castro Paro",
            Documento = "123.456.789-00",
            Telefone = "189810811",
            Endereco = "Rua Santa Terezinha, 1932",
            Bairro = "Centro",
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
            Idade = 4,
            IdDono = dono.Id
        };
        petRepo.Insert(pet);

        Console.WriteLine("✅ Dono e Pet inseridos com sucesso!");
    }
}
