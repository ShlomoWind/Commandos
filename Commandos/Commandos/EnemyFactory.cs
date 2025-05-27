using System.Collections.Generic;

public class EnemyFactory
{
    public List<Enemy> EnemyList { get; } = new List<Enemy>();
    public void AddEnemy(string name)
    {
        EnemyList.Add(new Enemy(name));
    }


}