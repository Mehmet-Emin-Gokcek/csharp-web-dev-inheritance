using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{


    //For a child class: add at least 1 additional field and 1 additional method
    public class Laptop : Computer
    {
       public Boolean IsBatteryDead { get; set; }
        static string BatteryLife { get; } = "10hrs";

        public Laptop( string name, int memoryCapacity, int memoryUsed) : base(name, memoryCapacity, memoryUsed) {       
        }

        public void BatteryDead()
        {
            IsBatteryDead = false;
        }
    }
}
