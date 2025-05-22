using System;



public abstract class Weapon
{
	public abstract string Name { get; set; }
	public abstract int AmmunitionCapacity { get; set; }
	public abstract int Energy { get; set; }
	public abstract string TypeOfBomb { get; set; }
}

