namespace DesignPatternPK.Mediator_VS_Facade.Facade
{
    //奖金计算
    class Bonus
    {
        //考勤情况
        private Attendance attendance = new Attendance();

        //获取奖金
        public int GetBonus()
        {
            int workDays = attendance.GetWorkDays();    //获取出勤天数
            int bonus = workDays * 1800 / 30;   //计算奖金
            return bonus;
        }
    }
}
