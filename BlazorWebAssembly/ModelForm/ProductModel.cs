using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssembly.ModelForm;

public class ProductModel
{
    
    public string Picture { get; set; }
    [MinLength(2)]
    public string Name { get; set; }
    [Range(0,100000)]
    public decimal Price { get; set; }
    
    public string Description { get; set; }
    
    public int Count { get; set; }
    
    public string Category { get; set; }
}