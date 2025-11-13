using PetShop.Domain.Base;

namespace PetshopStore.Domain.Entities
{
    public class Dono : BaseEntity<int>
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string Bairro { get; set; }
        public string Senha { get; set; }
        public int IdCidade { get; set; } 

        //  Navegação
        public Cidade CidadeObj { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public ICollection<Venda> Vendas { get; set; }

        public Dono() { }

        public Dono(int id, string nome, string endereco, string documento, string bairro,int idCidade, string email
            , string telefone,string senha   ): base(id)
        {
            Nome = nome;
            Endereco = endereco;
            Documento = documento;
            Bairro = bairro;
            IdCidade = idCidade;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }
    }
}
