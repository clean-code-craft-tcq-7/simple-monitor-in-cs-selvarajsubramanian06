using System;
using System.Diagnostics;

class Checker
{
    

    static bool socIsOk(float soc)
    {
         if(soc < 20 || soc > 80) 
         {
            Console.WriteLine("State of Charge is out of range!");
            return false;
         }
        return true;
    }

    static bool chargeRateIsOk(float chargeRate)
    {
         if(chargeRate > 0.8) 
         {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
         }
        return true;
    }
    
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {
        if(!temperatureCheck.temperatureIsOk(temperature) || !socIsOk(soc) || !chargeRateIsOk(chargeRate)) 
        {
            return false;
        } 
        return true;
    }

    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(batteryIsOk(25, 70, 0.7f));
        ExpectFalse(batteryIsOk(50, 85, 0.0f));
        Console.WriteLine("All ok");
        return 0;
        
    }
}
