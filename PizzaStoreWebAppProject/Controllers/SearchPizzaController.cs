using Microsoft.AspNetCore.Mvc;
using PizzaStoreWebAppProject.Interfaces;
using PizzaStoreWebAppProject.Models;
using PizzaStoreWebAppProject.Models.DTO;

namespace PizzaStoreApp.Controllers
{
    public class SearchPizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public SearchPizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public IActionResult GetPizzas()
        {
            PriceRangeDTO priceRange = new PriceRangeDTO
            {
                SearchedPizzas = new List<PizzaWithPicModel>()
            };
            return View(priceRange);
        }
        
        [HttpPost]
        public IActionResult GetPizzas(PriceRangeDTO priceRange)
        {
            var pizzas = _pizzaService.GetPizzaByRange(priceRange.Minimum, priceRange.Maximum);
            priceRange.SearchedPizzas = pizzas;
            return View(priceRange);
        }
    }
}