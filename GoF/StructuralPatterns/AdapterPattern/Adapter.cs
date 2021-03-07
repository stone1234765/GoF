using GoF.StructuralPatterns.AdapterPattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.AdapterPattern
{
    class Adapter
    {
        public void Run()
        {

            Console.WriteLine("Adapter");
            //First way
            Console.WriteLine("First way");
            var engine2 = new Engine2();
            var car = new Car(engine2);
            var engine87 = new Engine87();
            // Can not
            //var car2 = new Car(engine87);
            var engine87Adapter = new Engine87Adapter(engine87);
            var car3 = new Car(engine87Adapter);
            Console.WriteLine();
        }
    }
}
