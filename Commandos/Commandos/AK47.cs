using System;

public class AK47 : IWeapon
{
    private string Name = "AK47";
    private string ManufacturerName = "KALASHNIKOV";
    public int BulletsNumber { get; private set; } = 30;
    public void Shoot()
    {
        Console.WriteLine("sssshoot");
        this.BulletsNumber -= 1;
    }
}