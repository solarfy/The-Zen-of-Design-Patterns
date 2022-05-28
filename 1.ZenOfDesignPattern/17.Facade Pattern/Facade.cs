namespace ZenOfDesignPattern.Facade_Pattern
{
    //门面对象
    class Facade
    {
        //被门面的对象
        private ClassA a = new();
        private ClassB b = new();
        private ClassC c = new();
        private Context context = new();

        //提供给外部的方法
        public void MethodA() => a.DoSomethingA();
        public void MethodB() => b.DoSomethingB();
        public void MethodC() => c.DoSomethingC();

        /* 不推荐使用该种写法；门面对象只是提供一个访问子系统的一个路径而已，不应该参与具体的业务逻辑，否则会产生一个倒依赖的问题。
         * 子系统必须依赖门面才能被访问。              
         */
        //public void MethodMulti()
        //{         
        //    a.DoSomethingA();
        //    b.DoSomethingB();
        //    c.DoSomethingC();
        //}

        public void MethodMulti()
        {
            context.ComplexMethod();
        }
    }

    //该封装类的作用就是产生一个业务规则，并且它的生存环境是在子系统内（不需要访问门面对象）
    class Context
    {
        private ClassA a = new ClassA();
        private ClassB b = new ClassB();
        private ClassC c = new ClassC();

        public void ComplexMethod()
        {
            a.DoSomethingA();
            b.DoSomethingB();
            c.DoSomethingC();
        }
    }

}
