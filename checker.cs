using System;
using System.Diagnostics;

namespace SimpleMonitor
{
   
   class Checker
   {
   
        static bool batteryIsOk(float temperature, float soc, float chargeRate)
        {
           
            checkWithinRange.condition(temperature, BMS_Constants.tempMin, BMS_Constants.tempMax, "temperature");
            //Console.WriteLine(checkWithinRange.ResultMessage);

            //Console.Read();

            return false;
        }

        
        
        static int Main()
        {
            batteryIsOk(25, 70, 0.7f);
            batteryIsOk(50, 85, 0.0f);
            Console.WriteLine("All ok");
            return 0;

        }
    }
}
