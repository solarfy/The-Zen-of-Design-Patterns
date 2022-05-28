namespace ZenOfDesignPattern.Template_Method_Pattern
{
    //抽象模板类
    abstract class AbstractClass
    {
        //基本方法 - 由子类实现的方法，并在模板方法中调用。(尽量设计为protected)
        protected abstract void DoSomething();

        protected abstract void DoAnything();

        //钩子方法（此处使用属性）- 根据外部条件的变化，决定模板方法的执行
        protected bool IsDoAnything { get; set; } = true;

        //模板方法 - 可以一个或几个，一般是一个具体方法，实现对基本方法的调度。
        public void TemplateMethod()
        {
            //调用基本方法完成相关逻辑
            this.DoSomething();

            if (IsDoAnything)
                this.DoAnything();
        }
    }
}
