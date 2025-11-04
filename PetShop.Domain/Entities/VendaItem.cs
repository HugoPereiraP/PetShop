using PetShot.Domain.Base;

namespace PetshopStore.Domain.Entities
{
    public class VendaItem : BaseEntity<int>
    {
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        // Navegação
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }

        public VendaItem() { }

        public VendaItem(int id, int idVenda, int idProduto, int quantidade, decimal valorUnitario)
            : base(id)
        {
            IdVenda = idVenda;
            IdProduto = idProduto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }
    }
}
