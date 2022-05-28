using System;

namespace DesignPatternPK.Mediator_VS_Facade.Facade
{
    //HR门面；增加一个门面，对子系统无任何影响
    class HRFacade
    {
        //总工资情况
        private SalaryProvider salaryProvider = new();
        //考勤情况
        private Attendance attendance = new();

        //查询一个人的总收入
        public int QuerySalary(string name, DateTime date)
        {
            return salaryProvider.TotalSalary();
        }

        //查询一个人的一个月工作了多少天
        public int QueryWorkDays(string name, DateTime date)
        {
            return attendance.GetWorkDays();
        }
    }
}
