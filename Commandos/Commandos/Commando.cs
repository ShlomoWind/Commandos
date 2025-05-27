using System;

public class Commando
{
    public string Name;
    public string CodeName;
    public string[] Tools = new string[5];
    public string Status;

    public Commando(string name, string codeName)
    {
        string[] tools = { "hammer", "chisel", "rope", "bag", "water bottle" };
        this.Name = name;
        this.CodeName = codeName;
        this.Tools = tools;
        this.Status = "standing";
    }

    public void Walk()
    {
        this.Status = "walking";
        Console.WriteLine("soldier is walking");
    }
    public void Hide()
    {
        this.Status = "hiding";
        Console.WriteLine("soldier is hid");
    }
    public void Attack()
    {
        Console.WriteLine($"soldier {this.CodeName} is attacking");
    }
}