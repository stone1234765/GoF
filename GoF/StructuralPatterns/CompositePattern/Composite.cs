using GoF.StructuralPatterns.CompositePattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.CompositePattern
{
    class Composite
    {
        public void Run()
        {

            Console.WriteLine("Composite");
            //First way
            Console.WriteLine("First way");
            var apple = new Apple();
            var smallBox = new FirstWay.Composite();
            var mediumBox = new FirstWay.Composite();
            var bigBox = new FirstWay.Composite();

            smallBox.AddComponent(new Apple());

            mediumBox.AddComponent(new Mouse());
            mediumBox.AddComponent(new Keyboard());

            bigBox.AddComponent(smallBox);
            bigBox.AddComponent(mediumBox);
            bigBox.AddComponent(new Computer());

            ShowData(apple);
            ShowData(smallBox);
            ShowData(mediumBox);
            ShowData(bigBox);


            //Second way
            Console.WriteLine("Second way");
            var apple2 = new SecontWay.Apple();
            var smallBox2 = new SecontWay.Computer();
            var mediumBox2 = new SecontWay.Computer();
            var bigBox2 = new SecontWay.Computer();

            smallBox2.AddComponent(new SecontWay.Apple());

            mediumBox2.AddComponent(new SecontWay.Mouse());
            mediumBox2.AddComponent(new SecontWay.Keyboard());

            bigBox2.AddComponent(smallBox2);
            bigBox2.AddComponent(mediumBox2);
            bigBox2.AddComponent(new SecontWay.Computer());

            ShowData2(apple2);
            ShowData2(smallBox2);
            ShowData2(mediumBox2);
            ShowData2(bigBox2);

            Console.WriteLine();
        }
        private void ShowData(IComponent component)
        {
            Console.WriteLine(component.Id);
            Console.WriteLine(component.Price);
            foreach (var option in component.Options)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
        }
        private void ShowData2(SecontWay.Component component)
        {
            Console.WriteLine(component.Id);
            Console.WriteLine(component.Price);
            foreach (var option in component.Options)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
        }
    }
}
