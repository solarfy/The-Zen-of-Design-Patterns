namespace DesignPatternPK.Decorator_VS_Adapter.Decorator
{
    //抽象装饰类
    abstract class AbsDecorator : ISwan
    {
        private ISwan swan;

        //装饰的是谁
        public AbsDecorator(ISwan _swan) => this.swan = _swan;

        public virtual void Appaearance()
        {
            this.swan.Appaearance();
        }

        public void Cry()
        {
            this.swan.Cry();
        }

        public virtual void Fly()
        {
            this.swan.Fly();
        }
    }
}
