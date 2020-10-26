using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer
    {
        //For a parent class: add 3 fields, 2 methods, and a constructor.

        public string Name { get; }
        public int MemoryCapacity { get; }
        public int MemoryUsed { get; }
        public int MemoryLeft { get; }



        public Computer(string name, int memoryCapacity, int memoryUsed) {
            Name = name;
            MemoryCapacity = memoryCapacity;
            MemoryUsed = memoryUsed;
            MemoryLeft = MemoryCapacity - MemoryUsed;
        }






    }
}
