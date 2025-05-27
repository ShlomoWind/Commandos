using System;
using System.Collections.Generic;

public class CommandFactory
{
    public List<Commando> CommandList { get; } = new List<Commando>();
    
    public void AddCommander(string typeOfCommander, string name, string codeName)
    {
        switch (typeOfCommander)
        {
            case "commando":
                CommandList.Add(new Commando(name,codeName));
                break;
            case "air command":
                CommandList.Add(new AirCommando(name,codeName));
                break;
            case "sea commando":
                CommandList.Add(new SeaCommando(name,codeName));
                break;
            default:
                Console.WriteLine("invalid choice");
                break;
        }
    }
}