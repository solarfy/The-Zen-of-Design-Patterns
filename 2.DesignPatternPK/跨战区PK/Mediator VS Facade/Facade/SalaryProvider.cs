namespace DesignPatternPK.Mediator_VS_Facade.Facade
{
    //总工资计算
    class SalaryProvider
    {
        //基本工资
        private BasicSalary basicSalary = new();
        //奖金
        private Bonus bonus = new();
        //绩效
        private Performance perf = new();
        //税收
        private Tax tax = new();

        //获取用户的总收入
        public int TotalSalary()
        {
            return basicSalary.GetBasicSalary() + bonus.GetBonus() + perf.GetPerformanceValue() - tax.GetTax();
        }

    }
}
