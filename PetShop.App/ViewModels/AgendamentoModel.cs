namespace PetShop.App.ViewModels
{
    public record AgendamentoModel(
        int Id,
        DateTime DataHora,
        decimal ValorTotal,
        string Status,
        int IdPet,
        int IdServico,
        string? NomePet,
        string? NomeServico
    );
}
