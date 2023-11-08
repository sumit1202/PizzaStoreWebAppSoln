using Microsoft.AspNetCore.Mvc;
using PIzzaStoreModelLibrary;
using PizzaStoreWebAppProject.Models;

namespace PizzaStoreWebAppProject.Controllers;

public class PizzaController : Controller
{ 
    static List<PizzaWithPicModel> pizzaList = new List<PizzaWithPicModel>()
        {
            new PizzaWithPicModel{Id=1,Name="Schezwan Margherita", Price=389,Quantity=3,Type="Non-Veg",Pic="/images/Pizza1.jpeg"},
            new PizzaWithPicModel{Id=2,Name="Ultimate Tandoori Veggie", Price=609,Quantity=2,Type="Veg" ,Pic="/images/Pizza2.jpeg"}
        };
    public IActionResult Index(){
        return View(pizzaList);
    }
}