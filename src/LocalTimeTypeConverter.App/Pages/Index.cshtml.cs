using LocalTimeTypeConverter.App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LocalTimeTypeConverter.App.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public ExampleModel? Example { get; set; }

    [BindProperty]
    public string? Message { get; set; }

    public IActionResult OnPost()
    {
        if (!this.ModelState.IsValid)
        {
            this.Message = "Model is invalid";
            return this.Page();
        }

        this.Message = $"Time bound to model as {this.Example?.Time.ToString()}";
        return this.Page();
    }
}
