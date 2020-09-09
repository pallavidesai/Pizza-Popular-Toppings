using Popular_Toppings.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popular_ToppingsTests
{
    public class TestData
    {
        public static List<Pizza> Pizzas { get; set; }

        public TestData()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza
                {
                    Toppings= new List<string> { "pepperoni" } 
                },

                new Pizza
                {
                    Toppings= new List<string> { "pepperoni" } 
                },

                new Pizza
                {
                    Toppings= new List<string> { "sausage", "pepperoni" }
                },

                new Pizza
                {
                    Toppings= new List<string> { "pepperoni" }
                },

                new Pizza
                {
                    Toppings= new List<string> { "sausage", "pepperoni" }
                },

                new Pizza
                {
                    Toppings= new List<string> { "pepperoni" }
                },

                new Pizza
                {
                    Toppings= new List<string> { "sausage", "pepperoni" }
                },

                new Pizza
                {
                    Toppings= new List<string> { "sausage", "pepperoni" }
                },

                new Pizza
                {
                    Toppings= new List<string> { "sausage", "pepperoni" }
                },

                new Pizza
                {
                    Toppings= new List<string> { "sausage", "pepperoni" }
                },

            };
        }
    }
}
