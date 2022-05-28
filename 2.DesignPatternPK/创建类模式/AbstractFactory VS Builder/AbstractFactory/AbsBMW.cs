namespace DesignPatternPK.AbstractFactory_VS_Builder.AbstractFactory
{
    //抽象宝马车
    abstract class AbsBMW : ICar
    {
        public string GetBand()
        {
            return "宝马汽车";
        }

        public abstract string GetModel();
        public void Run()
        {
            System.Console.WriteLine($"{GetBand()} {GetModel()} 跑起来了");
        }
    }
}
