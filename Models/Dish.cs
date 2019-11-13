using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsNDishes.Models
{
  public class Dish
  {
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "Name of dish is required")]
    public string DishName { get; set; }


    [Required]
    [Range(1, 5000, ErrorMessage = "Calories need to be greater than 0")]
    public int Calories { get; set; }


    [Required(ErrorMessage="Description is required")]
    public string Description { get; set; }


    // [Required(ErrorMessage = "Tastiness value 1-5 is required")]
    [Range(1, 5, ErrorMessage = "Tastiness value 1-5 is required")]
    public int? Tastiness { get; set; }


    public int ChefId { get; set; }


    public Chef Creator { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


  }
}