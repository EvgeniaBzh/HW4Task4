using System;

public interface IGeographicObject
{
    double X { get; set; }
    double Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    string GetInformation();
}

public class River : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }

    public string GetInformation()
    {
        return $"Name: {Name}, X: {X}, Y: {Y}, Description: {Description}, Flow Speed: {FlowSpeed}, Total Length: {TotalLength}";
    }
}

public class Mountain : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public string GetInformation()
    {
        return $"Name: {Name}, X: {X}, Y: {Y}, Description: {Description}, Highest Point: {HighestPoint}";
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
            Y = 36.789,
            Name = "Hoverla",
            Description = "Highest mountain of Ukraine",
            HighestPoint = 2061
        };

        Console.WriteLine(river.GetInformation());
        Console.WriteLine(mountain.GetInformation());

    }
}