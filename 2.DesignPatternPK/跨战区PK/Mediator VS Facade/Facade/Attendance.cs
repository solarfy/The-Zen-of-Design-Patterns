using System;

namespace DesignPatternPK.Mediator_VS_Facade.Facade
{
    //考勤情况
    class Attendance
    {
        //获取出勤天数
        public int GetWorkDays()
        {
            return new Random().Next(30);
        }
    }
}
