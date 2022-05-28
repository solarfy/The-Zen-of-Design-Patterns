namespace ZenOfDesignPattern.Visitor_Pattern
{
    //具体元素；
    class ConcreteElementA : AbsElement
    {
        //自己独有的字段
        public string SelfElementA { get; set; } = "ElementA";

        public ConcreteElementA(int _number, string _name) : base(_number, _name) 
        {
            
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
