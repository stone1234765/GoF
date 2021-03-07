using GoF.CreationalPatterns.AbstractFactoryPattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.AbstractFactoryPattern
{
    class AbstractFactory
    {
        public void Run()
        {
            Console.WriteLine("Abstract factory");
            //First way
            Console.WriteLine("First way");
            var linuxfactory = new LinuxFactory();
            var client = new Client(linuxfactory);
            client.Menu.OpenWindow(client.Window);
            var unixFacroty = new UnixFacroty();
            client = new Client(unixFacroty);
            client.Menu.OpenWindow(client.Window);

            Console.WriteLine();
        }
    }
}
