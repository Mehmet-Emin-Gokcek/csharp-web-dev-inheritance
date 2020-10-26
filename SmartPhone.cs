using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public Boolean IsBatteryDead { get; set; }
        static string BatteryLife { get; } = "6hrs";

        public SmartPhone(string name, int memoryCapacity, int memoryUsed) : base(name, memoryCapacity, memoryUsed)
        {
        }

        public void BatteryDead()
        {
            IsBatteryDead = false;
        }
    }
}
