namespace ZenOfDesignPattern.Command_Pattern
{
    public class Command2 : AbstractCommand
    {
        public Command2(AbstractReceiver _receiver) : base(_receiver)
        {
            //this.receiver = new ReceiverB();
        }
     
        //可默认指定一个Receiver，对外公布一个setter，这样就可以封闭Receiver
        public void SetReceiver(AbstractReceiver _receiver) => this.receiver = _receiver;

        public override void Execute()
        {
            receiver.DoSomething();
        }
    }
}
