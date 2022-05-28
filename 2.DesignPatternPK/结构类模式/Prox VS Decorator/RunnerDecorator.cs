namespace DesignPatternPK.Prox_VS_Decorator
{
    class RunnerDecorator : IRunner
    {
        private IRunner runner;

        public RunnerDecorator(IRunner _runner) => this.runner = _runner;

        public void Run()
        {
            System.Console.WriteLine("加快运动员的速度：为运动员增加喷气装置");
            this.runner.Run();
        }
    }
}
