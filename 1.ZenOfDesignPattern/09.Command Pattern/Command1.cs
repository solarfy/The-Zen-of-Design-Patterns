namespace ZenOfDesignPattern.Command_Pattern
{
    public class Command1 : AbstractCommand
    {       
        public Command1(AbstractReceiver _receiver) : base(_receiver)
        {
            //this.receiver = new ReceiverA();
        }

        //可默认指定一个Receiver，对外公布一个setter，这样就可以封闭Receiver
        public void SetReceiver(AbstractReceiver _receiver) => this.receiver = _receiver;

        public override void Execute()
        {
            receiver.DoSomething();
        }
    }
}
