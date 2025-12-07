using PetShop.App.ViewModels;

public record GrupoModel(
    int Id,
    string Nome,
    List<ProdutoModel> Produtos
);
