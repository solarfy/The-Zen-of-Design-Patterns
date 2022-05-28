using System;

namespace DesignPatternPK.Prox_VS_Decorator
{
    //代理类
    class RunnerAgent : IRunner
    {
        private IRunner runner;
        public RunnerAgent(IRunner _runner) => this.runner = _runner;
        public void Run()
        {
            //int rand = new Random().Next(1, 3);

            //if (rand == 1)
            //    Console.WriteLine("代理人心情不好，不安排运动员跑步");
            //else
            {
                Console.WriteLine("代理人同样安排跑步");
                this.runner.Run();
            }
        }
    }
}
