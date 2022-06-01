using System;

namespace NewDesignPattern.Hire_Hand_Pattern
{
    //衣服
    class Cloth : ICleanable
    {
        public void Clean()
        {
            Console.WriteLine("衣服被清洁了");
        }
    }
}
