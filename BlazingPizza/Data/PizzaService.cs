namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        Pizza[] pizzas = new Pizza[]
        {
            new Pizza { PizzaId = 1, Name = "Margherita", Description = "False", Vegetarian = false, Vegan = false, Price = 14 },
            new Pizza { PizzaId = 2, Name = "Hawaiian", Description = "False", Vegetarian = false, Vegan = false, Price = 11 },
            new Pizza { PizzaId = 3, Name = "Fiorentina", Description = "False", Vegetarian = false, Vegan = false, Price = 10 },
            new Pizza { PizzaId = 4, Name = "Italiano", Description = "False", Vegetarian = false, Vegan = false, Price = 12 },
            new Pizza { PizzaId = 5, Name = "Pepperoni", Description = "False", Vegetarian = false, Vegan = false, Price = 14 }
        };

        return Task.FromResult(pizzas);
    }
}