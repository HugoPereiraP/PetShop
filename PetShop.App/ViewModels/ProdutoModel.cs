namespace PetShop.App.ViewModels;

public record ProdutoModel(
    int Id,
    string Nome,
    decimal Preco,
    int Quantidade,
    string UnidadeVenda,
    int IdGrupo,
    int Estoque
);
