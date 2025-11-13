using PetShop.Repository.Context;
using PetShop.Service;
using PetshopStore.Domain.Entities;

namespace PetShop.Test
{
    [TestClass]
    public class DonoServiceTest
    {
        [TestMethod]
        public void TestarCadastroEDepoisLogin()
        {
            var context = new PetShopContext();

            // 1. Criar a cidade (precisa existir antes do dono)
            var cidade = new Cidade
            {
                Nome = "São Paulo",
                Estado = "SP"
            };
            context.Cidades.Add(cidade);
            context.SaveChanges(); // salva a cidade para gerar o Id

            // 2. Criar o dono
            var novoDono = new Dono
            {
                Nome = "Hugo Pereira",
                Email = "hugo@gmail.com",
                Senha = "1234",
                Documento = "111.222.333-44",
                Telefone = "99999-9999",
                Endereco = "Rua das Flores, 123",
                Bairro = "Centro",
                IdCidade = cidade.Id,
                CidadeObj = cidade
            };

            // 3. Cadastrar o dono
            var donoService = new DonoService();
            donoService.Cadastrar(novoDono);

            // 4. Validar login
            var donoLogado = donoService.ValidarLogin("hugo@gmail.com", "1234");

            Assert.IsNotNull(donoLogado);
            Console.WriteLine($"Login feito com sucesso! Bem-vindo, {donoLogado.Nome}");
        }
    }
}
