using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.AbstractFactoryPattern.FirstWay
{
    class Client
    {
        public IMenu Menu { get; set; }
        public IWindow Window { get; set; }
        public Client(IAbstractFactory factory)
        {
            Menu = factory.CreateMenu();
            Window = factory.CreateWindow();
        }
    }
}
