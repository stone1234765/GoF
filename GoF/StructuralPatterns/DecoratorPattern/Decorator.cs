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


            //Second way
            Console.WriteLine("Second way");
            var secondEspresso = new SecondWay.Espresso();
            var secondEspressoWithMilk = new SecondWay.MilkDecorator(secondEspresso);
            var secondCappuccino = new SecondWay.WhippedMilkDecorator(secondEspressoWithMilk);
            var secondCappuccinoWithDoubleChocolate = new SecondWay.ChocolateDecorator(new SecondWay.ChocolateDecorator(secondCappuccino));
            SecondShowCoffee(secondEspresso);
            SecondShowCoffee(secondEspressoWithMilk);
            SecondShowCoffee(secondCappuccino);
            SecondShowCoffee(secondCappuccinoWithDoubleChocolate);

            Console.WriteLine();
        }
        private void ShowCoffee(Coffee coffee)
        {
            Console.WriteLine(coffee.Price);
            foreach (var ingredient in coffee.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine();
        }
        private void SecondShowCoffee(SecondWay.ICoffee coffee)
        {
            Console.WriteLine(coffee.Price);
            foreach (var ingredient in coffee.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine();
        }
    }
}
