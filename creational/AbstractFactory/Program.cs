﻿// See https://aka.ms/new-console-template for more information
using AbstractFactory.Creator.ConcreteFactory;
using AbstractFactory.Interface.Factory;

// The client code can work with any concrete factory class.
Console.WriteLine("Client: Testing client code with the first factory type...");
ClientMethod(new ConcreteFactory1());
Console.WriteLine();

Console.WriteLine("Client: Testing the same client code with the second factory type...");
ClientMethod(new ConcreteFactory2());
Console.WriteLine();

Console.WriteLine("Client: Testing the same client code with the third factory type...");
ClientMethod(new ConcreteFactory2());
Console.WriteLine();


void ClientMethod(IAbstractFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();
    var productC = factory.CreateProductC();

    Console.WriteLine(productB.UsefulFunctionB());
    Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    Console.WriteLine(productC.UsefulFunctionC());
}


