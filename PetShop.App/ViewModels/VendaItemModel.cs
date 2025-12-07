public record VendaItemDetailsModel(
    int Id,
    int IdVenda,
    int IdProduto,
    string ProdutoNome,
    int Quantidade,
    decimal ValorUnitario,
    decimal TotalItem
);
