using System;

public class Weapon
{
    public string Name;
    public string ManufacturerName;
    public int BulletsNumber;

    public Weapon(string name, string manufacturerName)
    {
        this.Name = name;
        this.ManufacturerName = manufacturerName;
        this.BulletsNumber = 20;
    }
    public void Shoot()
    {
        Console.WriteLine("sssshoot");
        this.BulletsNumber -= 1;
    }
}