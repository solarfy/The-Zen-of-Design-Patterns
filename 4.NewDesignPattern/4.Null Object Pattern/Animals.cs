using System;

namespace NewDesignPattern.Null_Object_Pattern
{
    class NullAnimal : IAnimal
    {
        public void MakeSound()
        {
            //什么都不做
        }
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("汪~汪~汪~");
        }
    }

    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("喵~喵~喵~");
        }
    }
}
