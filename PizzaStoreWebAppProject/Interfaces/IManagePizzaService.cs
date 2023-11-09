using PizzaStoreWebAppProject.Models;

namespace PizzaStoreWebAppProject.Interfaces;

public interface IManagePizzaService
{
    PizzaWithPicModel AddPizza(PizzaWithPicModel pizza);
    PizzaWithPicModel UpdatePizzaPrice(PizzaWithPicModel pizza);
    PizzaWithPicModel UpdatePizzaQuantity(PizzaWithPicModel pizza);

}