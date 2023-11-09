using PizzaStoreWebAppProject.Models;

namespace PizzaStoreWebAppProject.Interfaces;

public interface IPizzaService
{
    public ICollection<PizzaWithPicModel> GetPizzaByRange(int min, int max);
    public ICollection<PizzaWithPicModel> GetPizzaByType(string type);
    public ICollection<PizzaWithPicModel> GetAllPizzas();

}