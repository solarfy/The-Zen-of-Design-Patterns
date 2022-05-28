namespace ZenOfDesignPattern.Command_Pattern
{
    public class RollBackCommand : AbstractCommand
    {       
        public RollBackCommand(AbstractReceiver _receiver) : base(_receiver)
        {
            
        }

        public override void Execute()
        {
            this.receiver.RollBack();
        }
    }
}
