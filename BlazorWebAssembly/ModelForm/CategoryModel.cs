using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssembly.ModelForm;

public class CategoryModel
{
    [Required(ErrorMessage = "Enter Category")]
    public string CategoryName { get; set; }
}