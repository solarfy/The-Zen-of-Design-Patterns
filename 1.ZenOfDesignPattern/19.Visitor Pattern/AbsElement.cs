namespace ZenOfDesignPattern.Visitor_Pattern
{
    //抽象元素；声明接受哪一类访问者访问
    abstract class AbsElement
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public AbsElement(int _number, string _name)
        {
            this.Number = _number;
            this.Name = _name;
        }

        //允许哪个访问者访问
        public abstract void Accept(IVisitor visitor);      
    }
}
