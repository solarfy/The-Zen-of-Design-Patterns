namespace DesignPatternPK.AbstractFactory_VS_Builder.Builder
{
    class Director
    {
        //声明对建造者的引用
        private AbsCarBuilder benzBuilder = new BenzBuilder();
        private AbsCarBuilder bmwBuilder = new BMWBuilder();
        private ICar CreateCar(AbsCarBuilder builder, string engine, string wheel)
        {
            //生产蓝图
            Blueprint bp = new Blueprint();
            bp.SetEngine(engine);
            bp.SetWheel(wheel);

            //建造者收到蓝图
            builder.ReceiveBlueprint(bp);

            //开始生产
            return builder.BuildCar();
        }

        //生产正版奔驰汽车
        public ICar CreateBenzCar()
        {
            return CreateCar(benzBuilder, "benz的引擎", "benz的轮胎");
        }

        //生产正版宝马汽车
        public ICar CreateBmwCar()
        {
            return CreateCar(bmwBuilder, "bmw的引擎", "bmw的轮胎");
        }

        //生产盗版奔驰汽车
        public ICar CreateComplexBenzCar()
        {
            return CreateCar(benzBuilder, "自行车的引擎", "拖拉机的轮胎");
        }

        //生产盗版宝马汽车
        public ICar CreateComplexBmwCar()
        {
            return CreateCar(bmwBuilder, "一顿饭", "双腿");
        }
    }
}
