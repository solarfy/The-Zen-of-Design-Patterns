using System;

namespace NewDesignPattern.Hire_Hand_Pattern
{
    //厨房
    class Kitchen : ICleanable
    {
        public void Clean()
        {
            Console.WriteLine("厨房被清洁了");
        }
    }
}
