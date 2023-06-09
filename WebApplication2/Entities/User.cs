using System;
using System.Collections.Generic;

namespace WebApplication2.Entities;

public partial class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Meal> Meals { get; set; } = new List<Meal>();
}
