using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Context;
using WebApplication2.ViewModels;

namespace WebApplication2.Pages;

public class MealsModel : PageModel
{
    public void OnGet()
    {
    }
    private readonly MealsDBContext _context;
    public MealsModel()
    { _context = new MealsDBContext();
    }
    public List<MealViewModel> Meals { get;set; } = default!; 
    
    public async Task OnGetAsync()
    { if (_context.Meals != null)
        { Meals = await _context.Meals
            .Include(m => m.User)
            .Select(m => new MealViewModel(m)).ToListAsync();
        }
    }
}