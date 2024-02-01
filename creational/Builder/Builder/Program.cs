// See https://aka.ms/new-console-template for more information
using Builder.Creator;
using Builder.Interface;

var builder = new ConcreteBuilder();
var builderFluent = new ConcreteBuilderFluent();

var director = new Director(builder, builderFluent);

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());


// the Fluent Builder pattern 
Console.WriteLine("Fluent Builder product:");
director.BuildFeaturedProduct();
Console.Write(builderFluent.GetProduct().ListParts());
builderFluent.Reset();