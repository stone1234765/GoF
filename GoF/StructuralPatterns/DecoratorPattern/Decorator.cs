using GoF.StructuralPatterns.DecoratorPattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern
{
    class Decorator
    {
        public void Run()
        {

            Console.WriteLine("Decorator");
            //First way
            Console.WriteLine("First way");
            var espresso = new Espresso();
            var espressoWithMilk = new MilkDecorator(espresso);
            var сappuccino = new WhippedMilkDecorator(espressoWithMilk);
            var сappuccinoWithDoubleChocolate = new ChocolateDecorator(new ChocolateDecorator(сappuccino));
            ShowCoffee(espresso);
            ShowCoffee(espressoWithMilk);
            ShowCoffee(сappuccino);
            ShowCoffee(сappuccinoWithDoubleChocolate);
            Console.WriteLine();
        }
        private void ShowCoffee(Coffee coffee)
        {
            Console.WriteLine(coffee.Price);
            foreach (var ingredient in coffee.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
