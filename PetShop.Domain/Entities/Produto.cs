using PetShot.Domain.Base;


namespace PetshopStore.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string UnidadeVenda { get; set; }
        public int IdGrupo { get; set; }

        // Navegação
        public Grupo Grupo { get; set; }
        public ICollection<VendaItem> VendaItens { get; set; }

        public Produto() { }

        public Produto(int id, string nome, decimal preco, int quantidade, string unidadeVenda, int idGrupo)
            : base(id)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            UnidadeVenda = unidadeVenda;
            IdGrupo = idGrupo;
        }
    }
}
