namespace DesignPatternPK.AbstractFactory_VS_Builder.AbstractFactory
{
    abstract class AbsBenz : ICar
    {
        public string GetBand()
        {
            return "奔驰汽车";
        }

        public abstract string GetModel();
        public void Run()
        {
            System.Console.WriteLine($"{GetBand()} {GetModel()} 跑起来了");
        }
    }
}
