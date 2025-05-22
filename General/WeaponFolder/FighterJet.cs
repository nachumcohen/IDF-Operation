using System;

public abstract class FighterJet : Weapon
{

    public override string Name { get; set; }
    public override int AmmunitionCapacity { get; set; }
    public override int Energy { get; set; }
    public override string TypeOfBomb { get; set; }

    public FighterJet(string name, int ammunitionCapacity, int energy, string typeOfBomb)
    {
        Name = name;
        AmmunitionCapacity = ammunitionCapacity;
        Energy = energy;
        TypeOfBomb = typeOfBomb;
       
    }
   

}
