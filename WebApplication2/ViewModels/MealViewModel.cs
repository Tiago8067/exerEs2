using WebApplication2.Entities;

namespace WebApplication2.ViewModels;

public class MealViewModel
{
    public MealViewModel(Meal meal)
    { Name = meal.Name;
        Calories = meal.Calories ?? 0;
        UserName = meal.User.Name;
        Date = meal.Date;
    }
    public string Name { get; set; }
    public int Calories { get; set; }
    public DateTime Date { get; set; }
    public string UserName { get; set; }
}