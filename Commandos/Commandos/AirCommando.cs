using System;

public class AirCommando : Commando
{
    
    private int NumberOfParachuting = 0;
    public AirCommando(string name, string codeName) : base(name, codeName) { }

    
    public void AddParachuting()
    {
        this.NumberOfParachuting++;
    }
    public override void Attack()
    {
        Console.WriteLine($"soldier {SayName("General")} from the AirCommando is attacking");
    }
}