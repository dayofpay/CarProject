using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Modules
{
    class FuelTank
    {
        public static double currentFuel { get; set; }
        public static void Check(double minimum,double maximum)
        {
            Console.WriteLine("Checking the Fuel tank ...");
            try
            {
                Random setFuel = new Random();
                currentFuel = setFuel.NextDouble() * (maximum - minimum) + minimum;
            }
            catch(Exception error)
            {
                Console.WriteLine("Error while trying to check the fuel level...ERROR CODE: 0x01");
            }
        }
    }
}
