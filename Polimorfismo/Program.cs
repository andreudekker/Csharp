using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            vehiculo vehiculo = new vehiculo();
            {
                vehiculo.miVehiculo("negro", 4, 5);
                vehiculo.miVehiculo();
                Console.ReadLine();
            }
        }
    }
}
