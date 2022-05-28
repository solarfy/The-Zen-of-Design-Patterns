using System;

namespace DesignPatternPK.FacotryMethod_VS_Builder.FactoryMethod
{
    //小超人
    class ChildSuperMan : ISuperMan
    {
        public void SpecialTalent()
        {
            Console.WriteLine("刀枪不入、快速移动");
        }
    }
}
