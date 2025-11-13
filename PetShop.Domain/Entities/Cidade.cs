using PetShop.Domain.Base;

namespace PetshopStore.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public string Nome { get; set; }
        public string Estado { get; set; }

        // Navegação
        public ICollection<Dono> Donos { get; set; }

        public Cidade() { }

        public Cidade(int id, string nome, string estado)
            : base(id)
        {
            Nome = nome;
            Estado = estado;
        }
    }
}
