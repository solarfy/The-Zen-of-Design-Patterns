using System;

namespace ZenOfDesignPattern.Adapter_Pattern
{
    //源角色；需进行转换的角色，它是已存在的、运行良好的类或对象。
    class Adaptee
    {
        //原有的业务逻辑
        public void DoSomething()
        {
            Console.WriteLine("源角色特有的业务逻辑");
        }
    }
}
