namespace DesignPatternPK.Prox_VS_Decorator
{
    //具体的运动员
    class Runner : IRunner
    {
        public void Run()
        {
            System.Console.WriteLine("运动员跑步：动作很潇洒");
        }
    }
}
