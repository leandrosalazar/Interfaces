using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces4
{
    class Leon : ICarniboro
    {
        public string Come()
        {
            return "debora la carne de sus presas.";
        }
        public string Carni()
        {
            throw new NotImplementedException();
        }
    }
}
