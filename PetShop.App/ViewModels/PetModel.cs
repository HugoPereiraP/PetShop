namespace PetShop.App.ViewModels;

public record PetModel(
    int Id,
    string Nome,
    string Especie,
    string Raca,
    int Idade,
    int IdDono,
    string Sexo,
    decimal Peso
);
