namespace DesignPatternPK.AbstractFactory_VS_Builder.Builder
{
    class Car : ICar
    {
        public string Wheel { get ; set ; }
        public string Engine { get; set; }

        private string logo;
        public Car(string wheel, string engine)
        {
            this.Wheel = wheel;
            this.Engine = engine;
        }

        public void SetLogo(string _logo) => logo = _logo;
        public string GetLogo() => logo;

        public override string ToString()
        {
            return $"厂商：{GetLogo()} 车轮：{Wheel} 引擎：{Engine}";
        }

        public void Run()
        {
            System.Console.WriteLine(this);
        }
    }
}
