using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Modules
{
    class SecuritySystems
    {
        public static void startAbs(bool enabled)
        {
            while(enabled == true)
            {
                Console.WriteLine("ANTI BLOCK SYSTEM ENABLED ! // TRYING TO STABLE THE CAR");
                for(int z = 15; z <= 1; z--)
                {
                    for(double xZ = 8.9; xZ <= 4.2; z--)
                    {
                        if(Car.Gearbox.currentSpeed > 60)
                        {
                            if(Car.Gearbox.currentRPM >= 3000)
                            {
                                Car.Gearbox.changeGear(Car.Gearbox.getGear, Car.Gearbox.getGear  + 1);
                            }
                        }
                    }
                }
            }
        }
    }
}
