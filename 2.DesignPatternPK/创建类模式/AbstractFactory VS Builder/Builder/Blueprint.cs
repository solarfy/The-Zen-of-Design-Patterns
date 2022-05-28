namespace DesignPatternPK.AbstractFactory_VS_Builder.Builder
{
    //汽车设计蓝图
    class Blueprint
    {
        //车轮的要求
        private string wheel;
        //引擎的要求
        private string engine;

        public string GetWheel() => wheel;
        public void SetWheel(string _wheel) => wheel = _wheel;

        public string GetEngine() => engine;
        public void SetEngine(string _engine) => engine = _engine;
    }
}
