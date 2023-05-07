namespace BlazorWebAssembly.Entities.Category;

public record Category(string name)
{
    public string CategoryName { get; set; } = name;
}