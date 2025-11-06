
using PetShop.Domain.Base;

namespace PetshopStore.Domain.Entities
{
    public class Dono : BaseEntity<int>
    {

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int IdCidade { get; set; }
        
        // Navegação
        public Cidade CidadeObj { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public ICollection<Venda> Vendas { get; set; }

        public Dono() { }

        public Dono(int id, string nome, string endereco, string documento, string bairro, string cidade, int idCidade)
            : base(id)
        {
            Nome = nome;
            Endereco = endereco;
            Documento = documento;
            Bairro = bairro;
            Cidade = cidade;
            IdCidade = idCidade;
        }
    }
}
