namespace ZenOfDesignPattern.Command_Pattern
{
    //抽象命令类
    public abstract class AbstractCommand
    {
        //对哪个接收者进行命令处理
        protected AbstractReceiver receiver;

        public AbstractCommand(AbstractReceiver _receiver) => this.receiver = _receiver;

        //每个命令类必须有一个执行命令的方法
        public abstract void Execute();
    }
}
