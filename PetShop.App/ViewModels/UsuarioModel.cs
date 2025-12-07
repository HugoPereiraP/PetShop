namespace PetShop.App.ViewModels;

public record UsuarioModel(
    int Id,
    string Nome,
    string Login,
    string Senha,
    string Email
);
