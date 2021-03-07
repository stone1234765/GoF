using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.AbstractFactoryPattern.FirstWay
{
    class LinuxFactory : IAbstractFactory
    {
        public IMenu CreateMenu()
        {
            return new LinuxMenu();
        }
        public IWindow CreateWindow()
        {
            return new LinuxWindow();
        }
    }
}
