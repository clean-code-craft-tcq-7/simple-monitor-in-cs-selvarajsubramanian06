using System;
using System.Diagnostics;

namespace SimpleMonitor
{

    public static class BMS_Constants
    {
        public const float socMin = 20f;
        public const float socMax = 80f;
        public const float tempMin = 0f;
        public const float tempMax = 45f;
        public const float chargeRateMax = 0.8f;
        public const float Tolerance = 5f;
    }
}
