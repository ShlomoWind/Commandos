using System.Collections.Generic;

public class WeaponFactory
{
    public List<IWeapon> WeaponList { get; } = new List<IWeapon>();
    public void AddWeapon(string weapon)
    {
        switch (weapon)
        {
            case "M16":
                WeaponList.Add(new M16());
                break;

            case "AK47":
                WeaponList.Add(new AK47());
                break;

            case "knife":
                WeaponList.Add(new Knife());
                break;
        }  
    } 
}