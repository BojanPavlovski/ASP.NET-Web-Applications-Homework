using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        //Use the static List of Pizzas in the StaticDb and create list of pizza view models
        //in the Index action in Pizza Controller and return it to the view.

        public IActionResult Index()
        {
            List<Pizza> pizzasDb = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaViewModels = pizzasDb.Select(x => PizzaMapper.PizzaViewModel(x)).ToList();
            return View(pizzaViewModels);
        }
        public IActionResult GetAllPizzas()
        {
            List<Pizza> pizzasDb = StaticDb.Pizzas;
            return View(pizzasDb);
        }
        //Use the id parameter in the Details action to find the pizza in the static list and return pizza view model to the view.
        //    If the pizza was not found or the parameter id was not provided return Empty result.
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }
            Pizza pizzasDb = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizzasDb == null)
            {
                return new EmptyResult();
            }
            //Use extension method for creating a mapper from Pizza Model to Pizza View Model.
            PizzaViewModel pizza = pizzasDb.PizzaViewModel();

            
            //PizzaViewModel pizzaViewModel = PizzaMapper.PizzaViewModel(pizzasDb);

            return View(pizza);
        }
    }
}
