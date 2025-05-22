using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.General;

namespace IDF_Operation.Enemy
{
   public class Terrorist : Soldier
    {
        public string Name { get; set
            {
                if (Name == null) { Name = value; }
            } }

        public int Rank { get; set { if (value <= 5 && value >= 1) { Rank = value; } } }

        public bool Status { get; set; }
        public Weapon Weapon { get; set; }
    }
}
