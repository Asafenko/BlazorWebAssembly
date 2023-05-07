namespace BlazorWebAssembly.Entities.Category;

public interface ICategoriesRepository
{
    void AddCategory(Category category);
    IReadOnlyList<Category> GetCategories();
}