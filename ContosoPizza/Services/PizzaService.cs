using ContosoPizza.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContosoPizza.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas { get; }
        // Already defined 2 kinds of pizza
        static int nextId = 3;
        // Constructor
        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
                new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
            };
        }

        // Lambda function, use get() function of Pizzas to get all the types
        public static List<Pizza> GetAll() => Pizzas;

        // Returns the first element of the sequence that satisfies function $p or a default value if no such element is found.
        public static Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        // Add a new kind of pizza
        public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        // Delete a kind of pizza
        public static void Delete(int id)
        {
            var pizza = Get(id);
            if(pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        // Update the pizza list
        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if(index == -1)
                return;

            Pizzas[index] = pizza;
        }
    }
}