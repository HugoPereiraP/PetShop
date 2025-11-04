using PetShot.Domain.Base;


namespace PetshopStore.Domain.Entities
{
    public class Grupo : BaseEntity<int>
    {
        public string Nome { get; set; }

        // Navegação
        public ICollection<Produto> Produtos { get; set; }

        public Grupo() { }

        public Grupo(int id, string nome)
            : base(id)
        {
            Nome = nome;
        }
    }
}
