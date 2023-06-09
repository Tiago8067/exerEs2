using System;
using System.Collections.Generic;

namespace WebApplication2.Entities;

public partial class Meal
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Calories { get; set; }

    public DateTime Date { get; set; }

    public Guid? UserId { get; set; }

    public virtual User? User { get; set; }
}
