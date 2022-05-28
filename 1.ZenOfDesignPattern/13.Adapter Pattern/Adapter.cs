namespace ZenOfDesignPattern.Adapter_Pattern
{
    //适配器；通过继承或者类关联的方式将源角色转换成目标角色。
    class Adapter : Adaptee, ITarget
    {
        //如果不采用继承（类适配器），可采用如下类关联的方式（对象适配器）
        //private Adaptee adaptee = null;
        //public Adapter(Adaptee _adaptee) => this.adaptee = _adaptee;

        public void Request()
        {
            base.DoSomething();
        }
    }
}
