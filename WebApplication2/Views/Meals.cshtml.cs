using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Context;
using WebApplication2.ViewModels;

namespace WebApplication2.Views;

public class Meals : PageModel
{
    public void OnGet()
    {
        
    }
    private readonly MealsDBContext _context;
    public Meals()
    { _context = new MealsDBContext();
    }
    public List<MealViewModel> Meal { get;set; } = default!; 
    
    public async Task OnGetAsync()
    { if (_context.Meals != null)
        { Meal = await _context.Meals
            .Include(m => m.User)
            .Select(m => new MealViewModel(m)).ToListAsync();
        }
    }
}