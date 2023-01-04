using System;
using System.Diagnostics;

class Checker
{
   
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {
        /*if(!temperatureCheck.temperatureIsOk(temperature) || !socCheck.socIsOk(soc)) || !chargeRateCheck.chargeRateIsOk(chargeRate))
        {
            return false;
        } 
        return true;*/
       return (temperatureCheck.temperatureIsOk(temperature) && socCheck.socIsOk(soc)) && chargeRateCheck.chargeRateIsOk(chargeRate))
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
