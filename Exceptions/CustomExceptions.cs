using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.Exceptions
{
    class NotHaveAvalbleSoldiers : Exception
    {
        public NotHaveAvalbleSoldiers() : base()
        {

        }
    }

    class NoTerroristAlives : Exception
    {
        public NoTerroristAlives() : base()
        {

        }
    }
    class NoTasks : Exception
    {
        public NoTasks() : base(){ }
    }
    class ICantAttack : Exception{
    
        public ICantAttack() : base()
        {

        }
    }

}
