﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_PizzaPlace
{   //Concrete Factory
    class NewYorkFranchise : IFranchise
    {
        IPizza cheesePizza = new NYCheesePizza();
        IPizza meatPizza = new NYMeatPizza();
        IPizza veggiePizza = new NYVeggiePizza();

        private string GetCheesePizza()
        {
            return cheesePizza.GetName();
        }

        private string GetMeatPizza()
        {
            return meatPizza.GetName();
        }

        private string GetVeggiePizza()
        {
            return veggiePizza.GetName();
        }

        private string GetCheesePizzaIngredients()
        {
            return cheesePizza.GetIngredients();
        }

        private string GetMeatPizzaIngredients()
        {
            return meatPizza.GetIngredients();
        }

        private string GetVeggiePizzaIngredients()
        {
            return veggiePizza.GetIngredients();
        }

        public string[] GetPizzas()
        {
            string [] pizzas = new string[3];

            pizzas[0] = GetCheesePizza();
            pizzas[1] = GetMeatPizza();
            pizzas[2] = GetVeggiePizza();

            return pizzas;
        }

        public string[] GetPizzaIngredients()
        {
            string[] ingredientLists = new string[3];

            ingredientLists[0] = GetCheesePizzaIngredients();
            ingredientLists[1] = GetMeatPizzaIngredients();
            ingredientLists[2] = GetVeggiePizzaIngredients();

            return ingredientLists;
        }
    }
}
