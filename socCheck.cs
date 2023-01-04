using System;
using System.Diagnostics;

public static class socCheck
{
public static bool socIsOk(float soc)
    {
         if(soc < 20 || soc > 80) 
         {
            Console.WriteLine("State of Charge is out of range!");
            return false;
         }
        return true;
    }
}
    
