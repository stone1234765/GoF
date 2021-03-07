using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.AbstractFactoryPattern.FirstWay
{
    class LinuxMenu : IMenu
    {
        public void OpenWindow(IWindow window)
        {
            Console.WriteLine($"{window.GetType().Name} say hello");
        }
    }
}
