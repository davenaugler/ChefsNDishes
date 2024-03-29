using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Models
{
  public class ChefsNDishesContext : DbContext
  {
    public ChefsNDishesContext(DbContextOptions options) : base(options) { }

    public DbSet<Dish> Dishes {get; set;}
    public DbSet<Chef> Chefs {get; set;}
    
  }
}
