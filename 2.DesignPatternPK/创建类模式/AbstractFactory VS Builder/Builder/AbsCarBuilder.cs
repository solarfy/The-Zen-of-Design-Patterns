namespace DesignPatternPK.AbstractFactory_VS_Builder.Builder
{
    abstract class AbsCarBuilder
    {               
        //设计蓝图
        private Blueprint bp;       
       
        //按照要求生产汽车
        public ICar BuildCar()
        {
            Car car = new Car(BuildWheel(), BuildEngine());
            car.SetLogo(Logo());
            return car;            
        }

        //接收一份设计蓝图
        public void ReceiveBlueprint(Blueprint _bp) => bp = _bp;

        //protected 只有建造者才能看懂蓝图
        protected Blueprint GetBlueprint() => bp;

        public abstract string BuildWheel();

        public abstract string BuildEngine();

        public abstract string Logo();
    }
}
