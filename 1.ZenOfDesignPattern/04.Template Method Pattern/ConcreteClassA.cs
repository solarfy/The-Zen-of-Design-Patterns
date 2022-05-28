using System;

namespace ZenOfDesignPattern.Template_Method_Pattern
{
    class ConcreteClassA : AbstractClass
    {
        protected override void DoAnything()
        {
            Console.WriteLine("具体模板类A-DoAnything");
        }

        protected override void DoSomething()
        {
            Console.WriteLine("具体模板类A-DoSomething");
        }

       public bool EnableDoAnything 
       {
            set => this.IsDoAnything = value;
       }
    }
}
