namespace PetShop.App.ViewModels;

public record VendaModel(
    int Id,
    DateTime Data,
    decimal ValorTotal,
    int IdDono,
    int IdUsuario
);
