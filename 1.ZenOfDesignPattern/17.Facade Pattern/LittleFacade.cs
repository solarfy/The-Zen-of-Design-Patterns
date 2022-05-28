namespace ZenOfDesignPattern.Facade_Pattern
{
    //新增门面 - 对外接口受限访问
    class LittleFacade
    {
        //引用原有的门面
        Facade facade = new();

        public void MethodB() => facade.MethodB();
    }
}
