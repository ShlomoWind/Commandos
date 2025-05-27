using System;

public class Stone : IWeapon
{
    private string Type;
    private string ManufacturerName;
    private string Color;
    private int Weight;
    private string status;
    private int NumberToBroken = 5;  //The number of blows until it breaks
    private int NumberOfBlows = 0;  //Number of hits so far
    public Stone(string type, string manufacturerName, string color, int weight)
    {
        this.Type = type;
        this.ManufacturerName = manufacturerName;
        this.Color = color;
        this.Weight = weight;
    }
    public void Shoot()
    {
        Console.WriteLine("Thwack!!!");
    }
}