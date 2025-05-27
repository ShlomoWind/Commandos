using System;

public class M16 :IWeapon
{
    private string Name = "M16";
    private string ManufacturerName = "COLT";
    public int BulletsNumber { get; private set; } = 29;
    public void Shoot()
    {
        Console.WriteLine("sssshoot");
        this.BulletsNumber -= 1;
    }
}