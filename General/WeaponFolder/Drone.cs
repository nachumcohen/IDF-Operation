using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace IDF_Operation.General
{
    public class Drone : Weapon
    {
        public override string Name { get; set; }
        public override int AmmunitionCapacity { get; set; }
        public override int Energy { get; set; }
        public override string TypeOfBomb { get; set; }

        public Drone(string name, int ammunitionCapacity, int energy, string typeOfBomb)
        {
            Name = name;
            AmmunitionCapacity = ammunitionCapacity;
            Energy = energy;
            TypeOfBomb = typeOfBomb;

        }
    }
}
