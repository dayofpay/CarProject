using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Car
{
    class Gearbox
    {
        public static string currentStickPosition
        {
            get;
            set;
        }
        public static double currentSpeed
        {
            get;
            set;
        }
        public static bool onUphill
        {
            get;
            set;
        }
        public static bool onDownhill
        {
            get;set;
        }
        public static double getAngle
        {
            get; set;
        }
        public static double currentRPM
        {
            get;
            set;
        }
        public static int getGear
        {
            get;
            set;
        }
        public static string currentMode
        {
            get;
            set;
        }
        public static void changeGear(int currentGear,int nextGear)
        {
            if(getGear != nextGear && nextGear <= 7) {
                changeGear(currentGear, nextGear);
            }
        }
        public static void onKickDownEvent()
        {
            changeGear(getGear, getGear - 2);
            currentMode = "Sport";
        }
        //////
        /// RUN EVENT
        /// 
        public static void carMoving()
        {

            // Brake

        }
    }
}
