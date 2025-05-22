using System;
using System.Security.Cryptography.X509Certificates;

public class Artillery : Weapon
{

    public override string Name { get; set; }
    public override int AmmunitionCapacity { get; set; } 
    public override int Energy { get; set; }
    public override string TypeOfBomb { get; set; }

    public Artillery(string name , int ammunitionCapacity, int energy, string typeOfBomb)
    {
        Name = name;
        AmmunitionCapacity = ammunitionCapacity;
        Energy = energy;
        TypeOfBomb = typeOfBomb;

    }
}
