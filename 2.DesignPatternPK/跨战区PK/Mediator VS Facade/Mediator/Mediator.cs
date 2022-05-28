using System;

namespace DesignPatternPK.Mediator_VS_Facade.Mediator
{
    class Mediator : AbsMediator
    {
        //职位下降，工资也会下降，税也下降
        public override void Down(IPosition position)
        {
            DownPosition();
            DownSalary();
            DownTax();
        }

        //工资下降，税也会下降
        public override void Down(ISalary salary)
        {
            DownSalary();
            DownTax();
        }

        //税下降，工资就会上升
        public override void Down(ITax tax)
        {
            DownTax();
            UpSalary();
        }

        //职位上升，工资也会上升，税也会上升
        public override void Up(IPosition position)
        {
            UpPositon();
            UpSalary();
            UpTax();
        }

        //工资上升，税也会上升
        public override void Up(ISalary salary)
        {
            UpSalary();
            UpTax();
        }

        //税上升，工资就会下降
        public override void Up(ITax tax)
        {
            UpTax();
            DownSalary();
        }

        private void UpSalary() => Console.WriteLine("工资翻倍，乐翻天");
        private void DownSalary() => Console.WriteLine("经济不景气，降低工资");

        private void UpPositon() => Console.WriteLine("职位上升，狂喜");
        private void DownPosition() => Console.WriteLine("官降三级，很痛苦");

        private void UpTax() => Console.WriteLine("税收上升，为国家做贡献");
        private void DownTax() => Console.WriteLine("税收降低，国家收入减少");                
    }
}
