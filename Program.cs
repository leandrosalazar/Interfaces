using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces4
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro max = new Perro();            
            Vaca lola = new Vaca();            
            Leon alex = new Leon();           
            Oveja lana = new Oveja();
            Console.WriteLine("Max, mi perro, " + max.Come());
            Console.WriteLine("Lola, la vaca de mi abuelo, " + lola.Come());
            Console.WriteLine("Alex, el leon del zoologico, " + alex.Come());            
            Console.WriteLine("Lana, la oveja del rebaño, " + lana.Come());
            Console.ReadKey();
        }
    }
}
