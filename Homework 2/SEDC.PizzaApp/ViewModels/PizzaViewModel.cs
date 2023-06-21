using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.ViewModels
{
    public class PizzaViewModel
    {
        //Create Pizza ViewModel with 
        //the following properties a.Id b.Name c. Price d. PizzaSize
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public bool HasExtra { get; set; }
    }
}
