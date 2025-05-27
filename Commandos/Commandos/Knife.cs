using System;

public class Knife : IWeapon
{
    private string Type;
    private string ManufacturerName;
    private string Color;
    private int Weight;

    public Knife(string type, string manufacturerName , string color, int weight)
    {
        this.Type = type;
        this.ManufacturerName = manufacturerName;
        this.Color = color;
        this.Weight = weight;
    }
    public void Shoot()
    {
        Console.WriteLine("Shnk!!!");
    }
}