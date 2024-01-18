using FactoryMethod.Type1;
using FactoryMethod.Type2;

var x1 = new ConcreteCreator1();
Console.WriteLine(x1.SomeOperation());

var x2 = new ConcreteCreator2();
Console.WriteLine(x2.SomeOperation());
