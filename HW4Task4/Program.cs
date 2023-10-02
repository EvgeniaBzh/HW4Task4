using System;
using System.Xml.Linq;

abstract class GeographicalObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual string GetInformation()
    {
        return $"Name: {Name}, X: {X}, Y: {Y}, Description: {Description}";
    }
}

class River: GeographicalObject
{
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }

    public override string GetInformation()
    {
        return base.GetInformation() + $", Flow Speed: {FlowSpeed}, Total Length: {TotalLength}";
    }
}

class Mountain : GeographicalObject
{
    public double HighestPoint { get; set; }

    public override string GetInformation()
    {
        return base.GetInformation() + $", Highest Point: {HighestPoint}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        River river = new River
        {
            X = 45.678,
            Y = 34.567,
            Name = "Dnipro",
            Description = "Big river in Ukraine",
            FlowSpeed = 2.5,
            TotalLength = 2200
        };

        Mountain mountain = new Mountain
        {
            X = 48.123,
            Y  = 36.789,
            Name = "Hoverla",
            Description = "Highest mountain of Ukraine",
            HighestPoint = 2061
        };

        Console.WriteLine(river.GetInformation());
        Console.WriteLine(mountain.GetInformation());

    }
}