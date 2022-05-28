using System;

namespace DesignPatternPK.Mediator_VS_Facade.Facade
{
    //绩效
    class Performance
    {
        //基本工资
        private BasicSalary salary = new BasicSalary();

        //绩效奖金
        public int GetPerformanceValue()
        {
            int perf = new Random().Next(100);

            return salary.GetBasicSalary() * perf / 100;
        }
    }
}
