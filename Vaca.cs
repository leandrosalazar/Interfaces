using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces4
{
    class Vaca : IHerviboro
    {
        public string Come()
        {
            return "frecuentemente come pasto.";
        }

        public string Hervi()
        {
            throw new NotImplementedException();            
        }
    }
}
