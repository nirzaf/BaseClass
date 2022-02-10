class Program
{
    static void Main(string[] args)
    {
        var bicycle = new Bicycle();
    }
}


class Vehicle
{
    public int NumberOfWheels { get; set; }

    public Vehicle(int numberOfWheels)
    {
        NumberOfWheels = numberOfWheels;
        PrintOutDescription();
    }


    protected virtual void PrintOutDescription()
    {
        Console.WriteLine($"The vehicle has {NumberOfWheels} wheels");
    }
}


class Bicycle : Vehicle
{
    public Bicycle() : base(2)
    {
    }

    protected override void PrintOutDescription()
    {
        Console.WriteLine($"The bicycle has {NumberOfWheels} wheels");
    }
}