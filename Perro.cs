using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces4
{
    class Perro : ICarniboro
    {
        public string Come()
        {
            return "se roba la carne del asado.";
            
        }
        public string Carni()
        {
            throw new NotImplementedException();
        }
    }
}
