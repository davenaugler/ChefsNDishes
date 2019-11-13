using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChefsNDishes.Models
{
  public class Chef
  {
    [Key]
    public int ChefId { get; set; }


    [Required(ErrorMessage="Chef's first name is required")]
    public string FirstName { get; set; }


    [Required(ErrorMessage="Chef's last name is required")]
    public string LastName { get; set; }


    [Required(ErrorMessage="Chef's birthdate is required")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }

    public int Age {get; set;}

    // public int Age {get; set;}
    public List<Dish> CreatedDishes { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


  }
}