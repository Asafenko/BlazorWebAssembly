namespace BlazorWebAssembly.Entities.Product;

public interface ICatalogProduct
{
    IReadOnlyList<Product> GetProducts();
    Product GetProductById(long id);
    void AddProduct(Product product);
}