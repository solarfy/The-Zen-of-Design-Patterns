namespace ZenOfDesignPattern.Command_Pattern
{
    //抽象接收者；接收命令，并执行相关业务。
    public abstract class AbstractReceiver
    {
        //每个接收者需完成的业务
        public abstract void DoSomething();

        //回滚；命令的撤销
        public abstract void RollBack();
    }
}
