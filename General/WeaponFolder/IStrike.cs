using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder
{
    internal interface IStrike
    {
        protected int EnergyPerKM { get; }

        bool TryingSendStrike(int _distance, int requiersBomb);
        bool CheckAvailebleStrike();
        void MoveToTarget();
        void Fire();
        void ComeHome();

    }
}
