using PetShop.Domain.Base;



namespace PetshopStore.Domain.Entities
{
    public class Agendamento : BaseEntity<int>
    {
        public DateTime DataHora { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; }
        public int IdPet { get; set; }
        public int IdServico { get; set; }

        // Navegação
        public Pet Pet { get; set; }
        public Servico Servico { get; set; }

        public Agendamento() { }

        public Agendamento(int id, DateTime dataHora, decimal valorTotal, string status, int idPet, int idServico)
            : base(id)
        {
            DataHora = dataHora;
            ValorTotal = valorTotal;
            Status = status;
            IdPet = idPet;
            IdServico = idServico;
        }
    }
}
