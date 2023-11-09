namespace PizzaStoreWebAppProject.Models.DTO
{
    public class PriceRangeDTO
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public ICollection<PizzaWithPicModel> SearchedPizzas { get; set; }
    }
}