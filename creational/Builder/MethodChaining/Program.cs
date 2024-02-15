
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Greeting greeting = GreetingBuilder
                            .CreateNew()
                            .GreetingTimeOfDay("Morning")
                            .GreetingTo("James Bond")
                            .Build();

Console.WriteLine(greeting.Message);

public sealed class Greeting
{
    private readonly string timeOfDay;
    private readonly string to;

    public Greeting(string timeOfDay, string to)
    {
        if (string.IsNullOrEmpty(timeOfDay))
            throw new ArgumentException("Time of Day must be set");

        if (string.IsNullOrEmpty(to))
            throw new ArgumentException("To must be set");

        this.timeOfDay = timeOfDay;
        this.to = to;
    }

    public string Message => $"Good {timeOfDay} {to}";
}

public interface IGreetingBuilderSetTimeOfDay
{
    IGreetingBuilderSetTo GreetingTimeOfDay(string timeOfDay);
}

public interface IGreetingBuilderSetTo
{
    IGreetingBuilder GreetingTo(string to);
}

public interface IGreetingBuilder
{
    Greeting Build();
}

public sealed class GreetingBuilder :
    IGreetingBuilderSetTimeOfDay,
    IGreetingBuilderSetTo,
    IGreetingBuilder
{
    private string timeOfDay = "";
    private string to = "";

    private GreetingBuilder() { }

    public static IGreetingBuilderSetTimeOfDay CreateNew()
    {
        return new GreetingBuilder();
    }

    public IGreetingBuilderSetTo GreetingTimeOfDay(string timeOfDay)
    {
        this.timeOfDay = timeOfDay;
        return this;
    }

    public IGreetingBuilder GreetingTo(string to)
    {
        this.to = to;
        return this;
    }

    public Greeting Build()
    {
        return new Greeting(timeOfDay, to);
    }
}



