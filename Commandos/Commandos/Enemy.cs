using System;

public class Enemy
{
    private string Name { get; set; }
    private int LIfe = 100;
    private bool Alive = true;
    
    public Enemy(string name)
    {
        this.Name = name;
    }
    public void Shout()
    {
        Console.WriteLine("i'm an enemy!!!");
    }
    public void Dead()
    {
        this.Alive = false;
    }
    public void LoweringLifeExpectancy()
    {
        this.LIfe -= 10;
    }

}