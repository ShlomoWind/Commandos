using System;

public class SeaCommando : Commando
{
    private int TotalKilometers = 0;
    public SeaCommando(string name, string codeName) :base(name, codeName) { }
    public void AddKilometers(int kilometers)
    {
        this.TotalKilometers += kilometers;
    }
    public override void Attack()
    {
        Console.WriteLine($"soldier {SayName("General")} from SeaCommando is attacking");
    }
}