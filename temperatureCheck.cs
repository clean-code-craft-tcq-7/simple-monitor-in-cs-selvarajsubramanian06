using System;
using System.Diagnostics;

public static class temperatureCheck
{
    public static bool temperatureIsOk(float temperature)
    {
         if(temperature < 0 || temperature > 45) 
         {
            Console.WriteLine("Temperature is out of range!");
            return false;
         }
        return true;
    }
}
    
