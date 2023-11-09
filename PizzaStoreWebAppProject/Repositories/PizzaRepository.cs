// using PizzaStoreApp.Exceptions;
using PizzaStoreWebAppProject.Exceptions;
using PizzaStoreWebAppProject.Interfaces;
using PizzaStoreWebAppProject.Models;

namespace PizzaStoreWebAppProject.Repositories
{
    public class PizzaRepository : IRepository<int, PizzaWithPicModel>
    {
        static List<PizzaWithPicModel> pizzas = new List<PizzaWithPicModel>()
        {
            new PizzaWithPicModel{Id=1,Name="Schezwan Margherita", Price=389,Quantity=3,Type="Non-Veg",Pic="/images/Pizza1.jpeg"},
            new PizzaWithPicModel{Id=2,Name="Ultimate Tandoori Veggie", Price=609,Quantity=2,Type="Veg" ,Pic="/images/Pizza2.jpeg"}
        };
        public PizzaWithPicModel Add(PizzaWithPicModel item)
        {
            if (item == null)
                throw new ArgumentNullException("No Pizza object present !");
            item.Id = GeterateIndex();
            pizzas.Add(item);
            return item;
        }

        private int GeterateIndex()
        {
            int id = pizzas.Count;
            return ++id;
        }

        public PizzaWithPicModel Delete(int key)
        {
            PizzaWithPicModel pizza = GetById(key);
            pizzas.Remove(pizza);//How will it compare the pizza object???
            return pizza;
        }

        public List<PizzaWithPicModel> GetAll()
        {
            if (pizzas.Count == 0)
                throw new PizzaStackEmptyException();

            return pizzas;
        }

        public PizzaWithPicModel Update(PizzaWithPicModel item)
        {
            PizzaWithPicModel pizza = GetById(item.Id);
            pizza.Name = item.Name;
            pizza.Price = item.Price;
            pizza.Quantity = item.Quantity;
            pizza.Type = item.Type;
            return pizza;
        }

        public PizzaWithPicModel GetById(int key)
        {
            PizzaWithPicModel pizza = pizzas.FirstOrDefault(p => p.Id == key); //LINQ -> Language Integrated Query
            if (pizza == null)
                throw new InvalidOperationException("No pizza with id " + key + " !");

            return pizza;
        }
    }
}