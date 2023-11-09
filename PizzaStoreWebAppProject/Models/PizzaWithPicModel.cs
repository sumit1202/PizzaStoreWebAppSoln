using PIzzaStoreModelLibrary;

namespace PizzaStoreWebAppProject.Models;

public class PizzaWithPicModel : Pizza{
    public string? Pic{get; set;}
    public override bool Equals(object? obj)
        {
            return ((PizzaWithPicModel)obj).Id== Id;
        }
}