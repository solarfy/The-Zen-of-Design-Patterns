using System;

namespace DesignPatternPK.Decorator_VS_Adapter.Adapter
{
    //白天鹅类
    class WhiteSwan : DesignPatternPK.Decorator_VS_Adapter.Decorator.ISwan
    {
        public void Appaearance()
        {
            Console.WriteLine("外形是纯白色，惹人喜爱");
        }

        public void Cry()
        {
            Console.WriteLine("叫声是克鲁---克鲁---克鲁");
        }

        public void Fly()
        {
            Console.WriteLine("能够飞行");
        }
    }
}
