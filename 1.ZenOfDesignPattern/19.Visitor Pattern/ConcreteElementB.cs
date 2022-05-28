namespace ZenOfDesignPattern.Visitor_Pattern
{
    class ConcreteElementB : AbsElement
    {
        //自己独有的字段
        public string SelfElementB { get; set; } = "ElementB";

        public ConcreteElementB(int _number, string _name) : base(_number, _name)
        {

        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
