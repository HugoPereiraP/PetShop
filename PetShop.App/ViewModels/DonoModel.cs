namespace PetShop.App.ViewModels;

public record DonoModel(
    int Id,
    string Nome,
    string Endereco,
    string Telefone,
    string Email,
    string Documento,
    string Bairro,
    int IdCidade
);
