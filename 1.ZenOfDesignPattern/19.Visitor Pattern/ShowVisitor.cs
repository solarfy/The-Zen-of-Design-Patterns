using System;

namespace ZenOfDesignPattern.Visitor_Pattern
{
    //具体的信息显示访问者
    class ShowVisitor : IShowVisitor
    {        
        public void Show()
        {            
            Console.WriteLine("End Show");
        }

        public void Visit(ConcreteElementA elementA)
        {
            Console.WriteLine($"Element={elementA.SelfElementA}, Number={elementA.Number}, Name={elementA.Name}");            
        }

        public void Visit(ConcreteElementB elementB)
        {
            Console.WriteLine($"Element={elementB.SelfElementB}, Number={elementB.Number * 10}, Name={elementB.Name}");            
        }

        public void Visit(ConcreteElementC elementC)
        {
            Console.WriteLine($"Element={elementC.SelfElementC}, Number={elementC.Number * 100}, Name={elementC.Name}");            
        }
    }
}
