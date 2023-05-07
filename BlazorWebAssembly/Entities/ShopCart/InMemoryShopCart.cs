namespace BlazorWebAssembly.Entities.Product;

public class InMemoryShopCart : IShopCart
{
    private readonly List<Product> _shopProduct = new();

    public IReadOnlyList<Product> GetShopProduct()
    {
        return _shopProduct;
    }

    public void AddProductInCart(Product product)
    {
        _shopProduct.Add(product);
    }

}