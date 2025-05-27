using System.Collections.Generic;

public class WeaponFactory
{
    public List<Weapon> WeaponList { get; } = new List<Weapon>();
    public void AddWeapon(string name, string manufacturerName)
    {
        WeaponList.Add(new Weapon(name, manufacturerName));
    }
}