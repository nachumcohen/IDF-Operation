using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder
{
     public class Zik : Drone
    {

        public Zik() : base()
        {
        }
        protected override string name => base.name + "Zik";
        public override int maxAmmmuniyion => 8;
        public override int maxEnergy => 100;

        //    private string name = "zik";
        //    private int ammunitionCapacity = 3;
        //    private string typeOfBomb = new Random().Next(0, 2) == 0 ? "Pepole" : "Car";


        //    public Zik(int ammunitionCapacity, int energy, string typeOfBomb) : base("zik", ammunitionCapacity, energy, typeOfBomb)
        //    {
        //        Energy = energy;
        //    }

        //    public override string Name { get { return name; } }

        //    public override int AmmunitionCapacity { get { return ammunitionCapacity; } set { if (value >= 0 && value <= 3) ammunitionCapacity = value;  } }
        //    public override int Energy { get; set; }
        //    public override string TypeOfBomb { get { return typeOfBomb; } set {if (value == "Pepole"|| value == "Car" ) typeOfBomb = value;  }}
    }
}
