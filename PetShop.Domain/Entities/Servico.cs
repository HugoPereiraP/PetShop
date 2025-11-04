using PetShot.Domain.Base;

namespace PetshopStore.Domain.Entities
{
    public class Servico : BaseEntity<int>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        // Navegação
        public ICollection<Agendamento> Agendamentos { get; set; }

        public Servico() { }

        public Servico(int id, string nome, string descricao, decimal preco)
            : base(id)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
    }
}
