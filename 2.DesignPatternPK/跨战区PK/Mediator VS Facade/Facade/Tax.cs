using System;

namespace DesignPatternPK.Mediator_VS_Facade.Facade
{
    //税收
    class Tax
    {
        public int GetTax()
        {
            return new Random().Next(300);
        }
    }
}
