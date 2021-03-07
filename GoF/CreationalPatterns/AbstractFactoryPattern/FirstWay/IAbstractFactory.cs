using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.AbstractFactoryPattern.FirstWay
{
    interface IAbstractFactory
    {
        IMenu CreateMenu();
        IWindow CreateWindow();
    }
}
