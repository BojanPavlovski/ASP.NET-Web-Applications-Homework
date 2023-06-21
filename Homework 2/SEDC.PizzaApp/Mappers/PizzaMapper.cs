using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;
using System.Reflection;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
    //    Create a Mapper from Pizza Domain Model to Pizza View Model
        public static PizzaViewModel PizzaViewModel(this Pizza pizzaDb)
        {
            return new PizzaViewModel
            {
                Id = pizzaDb.Id,
                Name = pizzaDb.Name,
                Price = pizzaDb.Price,
                PizzaSize = pizzaDb.PizzaSize,
                HasExtra = pizzaDb.HasExtra

            };
        } 
    }
}
