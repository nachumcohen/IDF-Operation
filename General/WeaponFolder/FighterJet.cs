using System;

public abstract class FighterJet : Weapon
{

    public abstract string Name { get; set; }
    public abstract int AmmunitionCapacity { get; set; }
    public abstract int Energy { get; set; }
    public abstract string TypeOfBomb { get; set; }

    public FighterJet(string name, int ammunitionCapacity, int energy, string typeOfBomb)
    {
        Name = name;
        AmmunitionCapacity = ammunitionCapacity;
        Energy = energy;
        TypeOfBomb = typeOfBomb;
       
    }
   

}
