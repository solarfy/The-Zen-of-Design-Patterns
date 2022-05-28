using System;

namespace DesignPatternPK.FacotryMethod_VS_Builder.Builder
{
    //超人产品类
    class SuperMan
    {
        //超人的躯体
        public string Body { get; set; }

        //超人的特殊技能
        public string SpecialTalent { get; set; }

        //超人的标志
        public string SpecialSymbol { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Body} {SpecialTalent} {SpecialSymbol}");
        }
    }
}
