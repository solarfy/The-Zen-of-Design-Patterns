namespace ZenOfDesignPattern.Command_Pattern
{
    //命令的调度者；调度者与接收者之间没有任何依赖关系，它只关心命令。
    //类似于手机上寄快递，只关心是否有人接单，不关心是哪个接单人。
    public class Invoker
    {
        private AbstractCommand command;

        public void SetCommand(AbstractCommand _command) => this.command = _command;

        public void Action() => command.Execute();
    }
}
