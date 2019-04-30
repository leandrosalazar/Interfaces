using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces4
{
    class Oveja : IHerviboro
    {
        public string Come()
        {
            return "le encanta comer pasto para tener una mejor digestión.";
        }
        public string Hervi()
        {
            throw new NotImplementedException();
        }
    }
}
