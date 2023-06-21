using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SEDC.PizzaApp.Models;
using System;
using static System.Collections.Specialized.BitVector32;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        //Add Index action that returns a view with a simple html that says “List of orders”. 
        //It should be accessed through custom route http://localhost:[port]/ListOrders
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        //Add Details action with optional parameter id.If id is null it should return empty action result,
        //else it should return a view with simple html.
        //It should be accessed through route http://localhost/[Controller Name]/Details/{id?}
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }

            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return new EmptyResult();
            }
            return View(order);
        }

        //Add an action that returns Json(create an example model, class by your choice), 
        //it should be accessed by http://localhost/[Controller Name]/JsonData.
        public IActionResult JsonData()
        {
            Pizza pizza = new Pizza
            {
                Id = 1,
                Name = "Pepperoni",
                Price = 250,
                IsOnPromotion = true
            };
            return new JsonResult(pizza);
        }

        //Add an action that redirects to Action Index in Home Controller.
        public IActionResult ReturnsActionIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
