using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsOnPromotion { get; set; }

        //extend the pizza model with the following properties:price(decimal),PizzaSize(enum),HasExtras(bool)
        public PizzaSize PizzaSize { get; set; }
        public bool HasExtra { get; set; }
    }
}
