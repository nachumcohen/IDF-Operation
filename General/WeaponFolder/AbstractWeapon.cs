using System;
using IDF_Operation.Enemy;
using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder;




public abstract class AbstractWeapon : IID
{



    public abstract int EnergyPerKM { get; }
    public abstract int maxAmmmuniyion { get; }
    public abstract  int maxEnergy { get; }


    public abstract string Name { get; protected set; }
	public abstract int AmmunitionCapacity { get; set; }
	public abstract int Energy { get; set; }
	public abstract string TypeOfBomb { get; protected set; }
    public abstract int UniqueId { get; }
    public abstract Soldier UniqueSoldier { get; }



    public abstract void LinkSoldierToWeapon(Soldier soldier);
}

