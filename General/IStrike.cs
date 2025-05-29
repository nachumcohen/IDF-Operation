using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General
{
    public interface IStrike
    {
        public bool IsAbillityToStrike(double distance, string attackArea);
        public void Strike(double distance, string area);
    }
}
