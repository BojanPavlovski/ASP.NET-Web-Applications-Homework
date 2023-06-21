using System.Net;

namespace SEDC.PizzaApp.ViewModels
{
    public class OrderDetailsViewModel
    {
        public string UserFullName { get; set; }
        public string PizzaName { get; set; }
        public int OrderPrice { get; set; }
        public string PaymentMethod { get; set; }
        //Extend the OrderViewModel with property UserAddress from the address of 
        //the user and add it to the OrderDetailsViewModel Mapper.
        public string UserAddress { get; set; }
    }
}
