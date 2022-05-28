using System;

namespace DesignPatternPK.Decorator_VS_Adapter.Adapter
{
    //小鸭子
    class Duckling : IDuck
    {
        public void Appearance()
        {
            Console.WriteLine("外形是黄白相间，嘴长");
        }

        public void Behavior()
        {
            Console.WriteLine("会游泳");
        }

        public void Cry()
        {
            Console.WriteLine("叫声是嘎---嘎---嘎");
        }
    }
}
