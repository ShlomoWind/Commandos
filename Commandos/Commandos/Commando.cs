using System;

public class Commando
{
    private string Name;
    private string CodeName;
    private string[] Tools = new string[5];
    private string Status;

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
    public virtual void Attack()
    {
        Console.WriteLine($"soldier {this.Name} is attacking");
    }
    public string SayName(string commanderRank)
    {
        if(commanderRank == "General")
        {
            return this.Name;
        }
        else if(commanderRank == "Colonel")
        {
            return this.CodeName;
        }
        else
        {
            return "No access! Classified information!";
        }
    }
}