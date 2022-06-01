using System;

namespace NewDesignPattern.Hire_Hand_Pattern
{
    //花园
    class Garden : ICleanable
    {
        public void Clean()
        {
            Console.WriteLine("花园被清洁了");
        }
    }
}
