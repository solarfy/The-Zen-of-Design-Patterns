namespace DesignPatternPK.Cmd_VS_Strategy.Cmd
{
    //抽象命令类
    abstract class AbsCmd
    {
        //命令接收者（命令执行者）
        protected IReceiver zip = new ZipReceiver();
        protected IReceiver gzip = new GzipReceiver();

        //抽象方法，命令的具体单元
        public abstract bool Execute(string source, string to);
    }
}
