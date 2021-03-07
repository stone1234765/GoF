using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.AbstractFactoryPattern.FirstWay
{
    class UnixFacroty : IAbstractFactory
    {
        public IMenu CreateMenu()
        {
            return new UnixMenu();
        }
        public IWindow CreateWindow()
        {
            return new UnixWindow();
        }
    }
}
