using System;
using IDF_Operation.Enemy;
using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder;




public abstract class AbstractWeapon : IID
{


    public abstract string Name { get; protected set; }
    public abstract int UniqueId { get; }
    public abstract Soldier UniqueSoldier { get; }
    public abstract void LinkSoldierToWeapon(Soldier soldier);
}

