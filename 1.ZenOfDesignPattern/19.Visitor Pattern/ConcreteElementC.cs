namespace ZenOfDesignPattern.Visitor_Pattern
{
    class ConcreteElementC : AbsElement
    {
        //自己独有的字段
        public string SelfElementC { get; set; } = "ElementC";

        public ConcreteElementC(int _number, string _name) : base(_number, _name)
        {

        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
