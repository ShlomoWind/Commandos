using System.Collections.Generic;

public class EnemyFactory
{
    private List<Enemy> EnemyList = new List<Enemy>();
    public void AddEnemy(string name)
    {
        EnemyList.Add(new Enemy(name));
    }


}