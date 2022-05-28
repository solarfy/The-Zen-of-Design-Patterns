using System;

namespace DesignPatternPK.FacotryMethod_VS_Builder.FactoryMethod
{
    //成年超人
    class AdultSuperMan : ISuperMan
    {
        public void SpecialTalent()
        {
            Console.WriteLine("超人力大无穷");
        }
    }
}
