

using PetShop.Domain.Base;


namespace PetshopStore.Domain.Entities
{
    public class Venda : BaseEntity<int>
    {
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdDono { get; set; }
        public int IdUsuario { get; set; }

        // Navegação
        public Dono Dono { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<VendaItem> VendaItens { get; set; }

        public Venda() { }

        public Venda(int id, DateTime data, decimal valorTotal, int idDono, int idUsuario)
            : base(id)
        {
            Data = data;
            ValorTotal = valorTotal;
            IdDono = idDono;
            IdUsuario = idUsuario;
        }
    }
}
