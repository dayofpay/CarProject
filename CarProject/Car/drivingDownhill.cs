﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Car
{
    class drivingDownhill
    {
        public static void isDrivingDownHill()
        {
            if (Gearbox.getAngle > -60 && Gearbox.getGear > 3 && Gearbox.currentRPM <= 2750)
            {
                try
                {
                    Console.WriteLine($"Changed Gear {Gearbox.getGear} > {Gearbox.getGear + 2} ");
                    Gearbox.changeGear(Gearbox.getGear, Gearbox.getGear + 2);
                }
                catch (MethodAccessException error)
                {
                    Console.WriteLine("[ERROR] Error trying to change gear !");
                }
            }
        }
    }
}
