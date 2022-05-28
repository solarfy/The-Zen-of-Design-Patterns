namespace DesignPatternPK.Packaging_mode_group.Decorator
{
    //抽线装饰类
    abstract class AbsDecorator : IStar
    {
        //装饰的对象
        protected IStar star;

        public AbsDecorator(IStar star) => this.star = star;

        public virtual void Act()
        {
            star.Act();
        }
    }
}
