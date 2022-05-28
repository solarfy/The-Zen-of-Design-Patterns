using System;

namespace DesignPatternPK.Decorator_VS_Adapter.Decorator
{
    //丑小鸭
    class UglyDuckling : ISwan
    {
        //丑小鸭的外形
        public void Appaearance()
        {
            Console.WriteLine("外形是脏兮兮的白色，毛茸茸的大脑袋");
        }

        //丑小鸭的叫声
        public void Cry()
        {
            Console.WriteLine("叫声是克鲁---克鲁---克鲁");
        }

        //丑小鸭还比较小，不会飞行
        public void Fly()
        {
            Console.WriteLine("不会飞行");
        }
    }
}
