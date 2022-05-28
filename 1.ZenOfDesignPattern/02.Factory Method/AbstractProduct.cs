using System;

namespace ZenOfDesignPattern.Factory_Method
{
    //抽象产品类
    internal abstract class AbstractProduct
    {
        //产品类的公共方法
        public void Method1()
        {
            Console.WriteLine("业务逻辑处理");
        }

        //产品类的抽象方法
        public abstract void Method2();        
    }
}
