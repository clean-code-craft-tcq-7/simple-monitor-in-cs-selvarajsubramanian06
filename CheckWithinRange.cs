namespace SimpleMonitor
{
    public class checkWithinRange
    {
        public static string conditionMessage = string.Empty;
        public static string ResultMessage = String.Empty;

        public static float findTolerance(float maxValue)
        {
            float tolerance = (BMS_Constants.Tolerance / 100f) * maxValue;
            return tolerance;
        }

        public static void condition(float value, float minLimit, float maxLimit, string type)
        {

            isLowBreach(value, minLimit, type);
            isLowWarning(value, minLimit, maxLimit, type);
            isNormal(value, minLimit, maxLimit, type);
            isHighWarning(value, minLimit, maxLimit, type);
            isHighBreach(value, maxLimit, type);
        }

        public static void isLowBreach(float value, float minLimit, string type)
        {
            if (value < minLimit)
            {
                ResultMessage += "LOW BREACH " + type;
            }
        }

        public static void isLowWarning(float value, float minLimit, float maxLimit, string type)
        {
            if (value > minLimit && (value < minLimit + findTolerance(maxLimit)))
            {
                ResultMessage += "LOW WARNING " + type; 
            }
        }
        public static void isHighBreach(float value, float maxLimit, string type)
        {
            if (value > maxLimit)
            {
                ResultMessage += "HIGH BREACH " + type; 
            }
        }
        public static void isHighWarning(float value, float minLimit, float maxLimit, string type)
        {
            if ((value > maxLimit - findTolerance(maxLimit)) && value < maxLimit)
            {
                ResultMessage += "HIGH WARNING " + type; 
            }
        }
        public static void isNormal(float value, float minLimit, float maxLimit, string type)
        {
            if (value > minLimit + findTolerance(maxLimit) && value < maxLimit - findTolerance(maxLimit))
            {
                ResultMessage += "NORMAL RANGE " + type; 

            }
        }

    }
}    
