using PetShot.Domain.Base;


namespace PetshopStore.Domain.Entities
{
    public class Pet : BaseEntity<int>
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdDono { get; set; }

        // Navegação
        public Dono Dono { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; }

        public Pet() { }

        public Pet(int id, string nome, string especie, string raca, DateTime dataNascimento, int idDono)
            : base(id)
        {
            Nome = nome;
            Especie = especie;
            Raca = raca;
            DataNascimento = dataNascimento;
            IdDono = idDono;
        }
    }
}
