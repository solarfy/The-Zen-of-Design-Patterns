namespace ZenOfDesignPattern.Visitor_Pattern
{
    //抽象访问者；抽象类或接口，声明访问者可以访问哪些元素
    interface IVisitor
    {
        void Visit(ConcreteElementA elementA);
        void Visit(ConcreteElementB elementB);
        void Visit(ConcreteElementC elementC);
    }
}
