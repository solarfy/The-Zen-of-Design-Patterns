using System;

namespace ZenOfDesignPattern.Visitor_Pattern
{
    class ElementFactory
    {
        public static AbsElement Create()
        {
            AbsElement element;
            int r = new Random().Next(1, 10);

            if (r > 6)
                element = new ConcreteElementA(r, "个");
            else if (r > 3)
                element = new ConcreteElementB(r, "十");
            else
                element = new ConcreteElementC(r, "百");

            return element;
        }        
    }
}
