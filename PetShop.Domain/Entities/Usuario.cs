using PetShop.Domain.Base;



namespace PetshopStore.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }

        // Navegação
        public ICollection<Venda> Vendas { get; set; }

        public Usuario() { }

        public Usuario(int id, string nome, string senha, string login, string email)
            : base(id)
        {
            Nome = nome;
            Senha = senha;
            Login = login;
            Email = email;
        }
    }
}
