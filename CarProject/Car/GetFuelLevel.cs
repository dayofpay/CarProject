using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Car
{
    class GetFuelLevel
    {
        public static void Check()
        {
            Modules.FuelTank.Check(0,65);
        }
    }
}
