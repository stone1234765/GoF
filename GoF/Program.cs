﻿using GoF.BehavioralPatterns.IteratorPattern;
using GoF.BehavioralPatterns.ChainOfResponsibilityPattern;
using GoF.CreationalPatterns.AbstractFactoryPattern;
using GoF.CreationalPatterns.BuilderPattern;
using GoF.CreationalPatterns.FactoryMethodPattern;
using GoF.CreationalPatterns.PrototypePattern;
using GoF.CreationalPatterns.SingletonPattern;
using GoF.StructuralPatterns.AdapterPattern;
using GoF.StructuralPatterns.BridgePattern;
using GoF.StructuralPatterns.CompositePattern;
using GoF.StructuralPatterns.DecoratorPattern;
using GoF.StructuralPatterns.FacadePattern;
using GoF.StructuralPatterns.FlyweightPattern;
using GoF.StructuralPatterns.ProxyPattern;
using System;
using GoF.BehavioralPatterns.MediatorPattern;

namespace GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;
            var fabricMethod = new FabricMethod();
            fabricMethod.Run();
            var abstractFactory = new AbstractFactory();
            abstractFactory.Run();
            var prototype = new Prototype();
            prototype.Run();
            var builder = new Builder();
            builder.Run();
            var decorator = new Decorator();
            decorator.Run();
            var adapter = new Adapter();
            adapter.Run();
            var proxy = new Proxy();
            proxy.Run();
            var facade = new Facade();
            facade.Run();
            var composite = new Composite();
            composite.Run();
            var flyweight = new Flyweight();
            flyweight.Run();
            var bridge = new Bridge();
            bridge.Run();
            var chainOfResponsibility = new ChainOfResponsibility();
            chainOfResponsibility.Run();
            var iterator = new Iterator();
            iterator.Run();
            var mediator = new Mediator();
            mediator.Run();
        }
    }
}
