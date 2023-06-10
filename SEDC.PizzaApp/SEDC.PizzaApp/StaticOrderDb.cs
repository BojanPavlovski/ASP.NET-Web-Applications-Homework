using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public static class StaticOrderDb
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                IsDelivered = true,
                Price = 250
            },
            new Order()
            {
                Id = 2,
                IsDelivered = false,
                Price = 350
            },
            new Order()
            {
                Id = 3,
                IsDelivered = true,
                Price = 200
            }
        };
    }
}
