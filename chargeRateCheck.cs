using System;
using System.Diagnostics;

public static class chargeRateCheck
{
    static bool chargeRateIsOk(float chargeRate)
    {
         if(chargeRate > 0.8) 
         {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
         }
        return true;
    }
}
