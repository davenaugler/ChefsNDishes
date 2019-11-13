using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
  public class HomeController : Controller
  {
    private ChefsNDishesContext dbContext;

    public HomeController(ChefsNDishesContext context)
    {
      dbContext = context;
    }

    [HttpGet("")]
    public IActionResult Chefs()
    {
      List<Chef> ChefsDishes = dbContext.Chefs
        .Include(chef => chef.CreatedDishes)
        .ToList();
        // ChefsDishes.Reverse();

      return View(ChefsDishes);
    }

    [HttpPost]
    public IActionResult CreateNewChef(Chef newChef)
    {
      DateTime today = DateTime.Now;
      int calcage = today.Year - newChef.DateOfBirth.Year;
      newChef.Age = calcage;
      if (calcage < 18)
      {
        System.Console.WriteLine($"INSIDE DATEOFBIRTH IF **************************");
        ModelState.AddModelError("DateOfBirth", "Chef must be at least 18 years old");
        return View("NewChef");
      }
      if (ModelState.IsValid)
      {
        dbContext.Add(newChef);
        dbContext.SaveChanges();
        return Redirect("/");
      }
      else
      {
        return View("NewChef");
      }
    }

    [HttpGet("dishes")]
    public IActionResult Dishs()
    {
      List<Dish> listOfDishes = dbContext.Dishes
        .Include(dish => dish.Creator)
        .ToList();

      // return View("Dishs");
      return View(listOfDishes);
    }

    [HttpGet("dishes/new")]
    public IActionResult NewDish()
    {
      ChefsNDishesViewModel listOfChefs = new ChefsNDishesViewModel()
      {
        Chef = dbContext.Chefs.ToList()
      };
      // Chef singleChef = dbContext
      return View(listOfChefs);
    }

    [HttpPost]
    public IActionResult AddDish(ChefsNDishesViewModel modelData)
    {
      System.Console.WriteLine("########################################################");
      System.Console.WriteLine(modelData);
      System.Console.WriteLine($"ChefID: {modelData.Dishes.ChefId}");
      System.Console.WriteLine($"DishName: {modelData.Dishes.DishName}");
      System.Console.WriteLine($"Calories: {modelData.Dishes.Calories}");
      System.Console.WriteLine($"Description: {modelData.Dishes.Description}");
      System.Console.WriteLine($"Tastiness: {modelData.Dishes.Tastiness}");
      System.Console.WriteLine("########################################################");

      System.Console.WriteLine(modelData.Dishes.Description);
      System.Console.WriteLine(ModelState.IsValid);

      if (ModelState.IsValid)
      {
        System.Console.WriteLine("******************************************************");
        System.Console.WriteLine("Model State IsValid");
        dbContext.Dishes.Add(modelData.Dishes);
        System.Console.WriteLine(modelData.Dishes);
        dbContext.SaveChanges();
        return Redirect("/dishes");
      }
      else
      {
        ChefsNDishesViewModel listOfChefs = new ChefsNDishesViewModel()
        {
          Chef = dbContext.Chefs.ToList()
        };
        // return View("/dishes/new");
        return View("NewDish", listOfChefs);
      }
    }

    [HttpGet("new")]
    public IActionResult NewChef()
    {
      return View("NewChef");
    }


    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}